using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace ImageProcessing
{   
    internal struct GrayScale
    {
        public delegate byte Transformation(byte r, byte g, byte b);

        public static byte Cartesian(byte r, byte g, byte b)
        {
            return (byte)(0.577 * Math.Sqrt(r * r + g * g + b * b));
        }

        public static byte HSI(byte r, byte g, byte b)
        {
            return (byte)((r + g + b) / 3);
        }

        public static byte HSB(byte r, byte g, byte b)
        {
            return Math.Max(r, Math.Max(g, b));
        }

        public static byte HSL(byte r, byte g, byte b)
        {
            return (byte)((Math.Max(r, Math.Max(g, b)) + Math.Min(r, Math.Min(g, b))) / 2);
        }

        public static byte XYZ(byte r, byte g, byte b)
        {
            return (byte)(0.213 * r + 0.715 * g + 0.072 * b);
        }
    }

    internal struct Transformations
    {
        public delegate byte Transformation(byte r);

        public static byte Inversion(byte r)
        {
            return (byte)(255 - r);
        }

        public static byte Log(byte r, double Base, double c)
        {            
            return (byte)(c * Math.Log(r + 1, Base));
        }

        public static double LogCoef(double Base)
        {
            return 255 / Math.Log(255, Base);
        }

        public static byte Power(byte r, double Gamma, double c)
        {
            return (byte)(c * Math.Pow(r, Gamma));
        }

        public static double PowerCoef(double Gamma)
        {
            return 255 / Math.Pow(255, Gamma);
        } 

        public static byte PiecewiseLinear(byte r, Point[] Func)
        {
            for (int i = 1; i < Func.Length; ++i)
            {
                double x0 = Func[i - 1].X;
                double x1 = Func[i].X;
                if ((r >= x0) && (r < x1))
                {
                    double y0 = Func[i - 1].Y;
                    double y1 = Func[i].Y;
                    return (byte)(r == x0 ? y0 : (y1 - y0) * (r - x0) / (x1 - x0) + y0);    
                }
            }
            return r;
        }

        public static byte Binarization(byte r, byte Threshold)
        {
            return (byte)(r < Threshold ? 0 : 255);
        }

        public static byte BitPlane(byte r, byte Bit)
        {
            return (byte)((r << (7 - Bit)) & 0x80);            
        }
    }

    internal struct Histogram
    {
        public delegate byte LocalFilter(byte r, Double[] Histogram);

        public static void Integrate(Double[] Histogram)
        {
            for (int i = 1; i < Histogram.Length; ++i)
            {
                Histogram[i] = Histogram[i - 1] + Histogram[i];
            }
        }

        public static byte Apply(byte r, Double[] Histogram)
        {
            return (byte)(Histogram[r] * 255);
        }

        public static byte LocalEqualization(byte r, Double[] Histogram)
        {
            Integrate(Histogram);
            return (byte)(Histogram[r] * 255);
        }

        public static void CalcChars(double[] Histogram, out double Mean, out double Variance)
        {
            Mean = 0;
            Double MeanSqr = 0;
            for (int i = 0; i < Histogram.Length; ++i)
            {
                Mean += Histogram[i] * i;
                MeanSqr += Histogram[i] * i * i;
            }
            Variance = MeanSqr - Mean * Mean;
        }

        public static byte LocalCharsFilter(byte r, double[] Histogram, double GlobalMean, double GlobalVariance)
        {
            double LocalMean, LocalVariance;
            CalcChars(Histogram, out LocalMean, out LocalVariance);
            if ((LocalMean <= 0.4 * GlobalMean) && 
                (0.02 * Math.Sqrt(GlobalVariance) <= Math.Sqrt(LocalVariance)) && 
                (Math.Sqrt(LocalVariance) <= 0.4 * Math.Sqrt(GlobalVariance)))
            {
                return (byte)(r * 4);
            }           
            else return r;
        }
    }

    internal struct SpaceFilters
    {
        public delegate byte Filter(byte[] Aperture);

        public static byte Avg(byte[] Aperture)
        {
            return (byte)Aperture.Average(b => b);
        }

        public static byte Min(byte[] Aperture)
        {
            return Aperture.Min(b => b);
        }

        public static byte Max(byte[] Aperture)
        {            
            return Aperture.Max(b => b);
        }

        public static byte Median(byte[] Aperture)
        {
            Array.Sort(Aperture);
            return Aperture[Aperture.Length / 2];
        }

        public static byte Weight(byte[] Aperture)
        {
            return (byte)(0.0625 * (
                Aperture[0] +
                Aperture[1] * 2 +
                Aperture[2] +
                Aperture[3] * 2 +
                Aperture[4] * 4 +
                Aperture[5] * 2 +
                Aperture[6] +
                Aperture[7] * 2 +
                Aperture[8]));
        }

        public static byte Sobel(byte[] Aperture)
        { 
            var Gx = Aperture[6] + 2 * Aperture[7] + Aperture[8] - Aperture[0] - 2 * Aperture[1] - Aperture[2];
            var Gy = Aperture[2] + 2 * Aperture[5] + Aperture[8] - Aperture[0] - 2 * Aperture[3] - Aperture[6];
            return (byte)Math.Sqrt(Gx * Gx + Gy * Gy);
        }

        public static byte Roberts(byte[] Aperture)
        {
            var Gx = Aperture[8] - Aperture[4];
            var Gy = Aperture[7] - Aperture[5];
            return (byte)Math.Sqrt(Gx * Gx + Gy * Gy);
        }
    }

    internal class BmArrays : IDisposable
    {
        private byte[] SourceArr, GrayScaleArr, ProcessedArr;
        private GCHandle SourceHandle, GrayScaleHandle, ProcessedHandle;
        private bool Disposed = false;
        private delegate byte RectWalker(byte r, Rectangle Rect);

        static private Bitmap CreateBitmap(Size Size, bool GrayScale, out byte[] Arr, out GCHandle Handle)
        {
            var Format = GrayScale ? PixelFormat.Format8bppIndexed : PixelFormat.Format24bppRgb;
            var BitsPerPixel = ((int)Format >> 8) & 0xFF;
            var BytesPerPixel = (BitsPerPixel + 7) >> 3;
            var Stride = ((Size.Width * BytesPerPixel + 3) >> 2) << 2;           
            Arr = new byte[Size.Height * Stride];
            Handle = GCHandle.Alloc(Arr, GCHandleType.Pinned);
            var Result = new Bitmap(Size.Width, Size.Height, Stride, Format, Handle.AddrOfPinnedObject());
            if (GrayScale)
            {
                var Palette = Result.Palette;
                for (int i = 0; i <= 255; ++i)
                {
                    Palette.Entries[i] = Color.FromArgb(i, i, i);
                }
                Result.Palette = Palette;
            }
            return Result;
        }

        public BmArrays(Image Source)
        {
            SourceBitmap = CreateBitmap(Source.Size, false, out SourceArr, out SourceHandle);
            GrayScaleBitmap = CreateBitmap(Source.Size, true, out GrayScaleArr, out GrayScaleHandle);
            ProcessedBitmap = CreateBitmap(Source.Size, true, out ProcessedArr, out ProcessedHandle);
            using (var gr = Graphics.FromImage(SourceBitmap)) 
            {
                gr.DrawImage(Source, new Rectangle(0, 0, Source.Size.Width, Source.Size.Height));
            }                                    
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(true);
        }

        private void Dispose(bool Disposing)
        {
            if (!Disposed)
            {
                Disposed = true;
                SourceBitmap.Dispose();
                SourceHandle.Free();
                GrayScaleBitmap.Dispose();
                GrayScaleHandle.Free();
                ProcessedBitmap.Dispose();
                ProcessedHandle.Free();
                if (Disposing)
                {
                    SourceBitmap = null;
                    SourceArr = null;
                    GrayScaleBitmap = null;
                    GrayScaleArr = null;
                    ProcessedBitmap = null;
                    ProcessedArr = null;
                }
            }
        }

        ~BmArrays()
        {
            Dispose(false);
        }

        public void DoGrayScale(GrayScale.Transformation Transformation)
        {
            int Width = SourceBitmap.Width;
            int Height = SourceBitmap.Height;
            int SourceStride = SourceArr.Length / Height;
            int GrayScaleStride = GrayScaleArr.Length / Height;
            int SourceLine = 0;
            int GrayScaleLine = 0;
            for (int y = 0; y < Height; ++y)
            {
                int i = SourceLine;
                int j = GrayScaleLine;
                for (int x = 0; x < Width; ++x)
                {
                    GrayScaleArr[j] = Transformation(SourceArr[i + 2], SourceArr[i + 1], SourceArr[i]);
                    i += 3;
                    ++j;
                }
                SourceLine += SourceStride;
                GrayScaleLine += GrayScaleStride;
            }           
        }

        public void Transform(Transformations.Transformation Transformation)
        {
            for (int i = 0; i < GrayScaleArr.Length; ++i)
            {
                ProcessedArr[i] = Transformation(GrayScaleArr[i]);
            }
        }

        public Double[] CalcHistogram(Rectangle Rect)
        {            
            var Result = new Double[256];
            var Width = GrayScaleBitmap.Width;
            var Height = GrayScaleBitmap.Height;            
            var Rct = new Rectangle(0, 0, Width, Height);            
            if (!Rect.IsEmpty)
            {
                Rct.Intersect(Rect);
            }            
            if (Rct.IsEmpty)
            {
                return Result;
            }
            var Inc = 1.0 / (Rct.Width * Rct.Height);
            var Stride = GrayScaleArr.Length / Height;
            for (int y = Rct.Top; y < Rct.Bottom; ++y)
            {
                for (int x = Rct.Left; x < Rct.Right; ++x)
                {
                    Result[GrayScaleArr[y * Stride + x]] += Inc;
                }
            }
            return Result;            
        }

        private void WalkWithRect(RectWalker Callback)
        {
            var Stride = GrayScaleArr.Length / GrayScaleBitmap.Height;
            var Width = GrayScaleBitmap.Width;
            var Height = GrayScaleBitmap.Height;
            var Rect = new Rectangle(-1, -1, 3, 3);
            var Line = 0;
            for (int y = 0; y < Height; ++y)
            {
                var p = Line;
                for (int x = 0; x < Width; ++x)
                {                    
                    ProcessedArr[p] = Callback(GrayScaleArr[p], Rect);
                    Rect.Offset(1, 0);
                    ++p;
                }
                Rect.Offset(-Width, 1);
                Line += Stride;
            }
        }

        public void LocalHistogramFilter(Histogram.LocalFilter Filter)
        {
            WalkWithRect((r, Rect) => 
            {
                var Hist = CalcHistogram(Rect);
                return Filter(r, Hist);
            });                     
        }

        private byte[] CopyAperture(Rectangle Rect)
        {
            var Result = new Byte[Rect.Width * Rect.Height];
            var i = 0;
            var Stride = GrayScaleArr.Length / GrayScaleBitmap.Height;
            for (int y = Rect.Top; y < Rect.Bottom; ++y)
            {
                for (int x = Rect.Left; x < Rect.Right; ++x)
                {                    
                    if ((x < 0) || (y < 0) || (x >= GrayScaleBitmap.Width) || (y >= GrayScaleBitmap.Height))
                    {
                        Result[i] = 0;
                    }
                    else
                    {
                        Result[i] = GrayScaleArr[y * Stride + x];
                    }
                ++i;
                }
            }
            return Result;
        }

        public void SpaceFilter(SpaceFilters.Filter Filter)
        {
            WalkWithRect((r, Rect) => Filter(CopyAperture(Rect)));            
        }

        public Bitmap SourceBitmap { get; private set; }
        public Bitmap GrayScaleBitmap {get; private set;}
        public Bitmap ProcessedBitmap {get; private set;}
    }    
}
