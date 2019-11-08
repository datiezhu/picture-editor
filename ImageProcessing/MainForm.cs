using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Drawing.Drawing2D;

namespace ImageProcessing
{   
    public partial class MainForm : Form
    {
        private BmArrays Bitmaps;
        private delegate void GraphicPainter(PaintEventArgs e);
        private GraphicPainter graphicPainter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowGraphic(GraphicPainter Painter)
        {
            //graphicPainter = Painter;
            //pnlGraphic.Show();
            //pnlGraphic.Refresh();
        }

        private void OpenImage(Image Image)
        {
            if (Bitmaps != null)
            {
                pbSource.Image = null;
                pbGrayScale.Image = null;
                pbProcessed.Image = null;
                Bitmaps.Dispose();
                Bitmaps = null;
            }
            Bitmaps = new BmArrays(Image);
            pbSource.Image = Bitmaps.SourceBitmap;
            pbGrayScale.Image = Bitmaps.GrayScaleBitmap;
            pbProcessed.Image = Bitmaps.ProcessedBitmap;
        }

        private void tsmiOpenImage_Click(object sender, EventArgs e)
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                using (var bm = Image.FromFile(ofdOpenImage.FileName))
                {
                    OpenImage(bm);
                }                
            }
        }

        private void tsmiGrayScaleCartesian_Click(object sender, EventArgs e)
        {
            Bitmaps.DoGrayScale(GrayScale.Cartesian);
            pbGrayScale.Refresh();
        }

        private void tsmiGrayScaleHSI_Click(object sender, EventArgs e)
        {
            Bitmaps.DoGrayScale(GrayScale.HSI);
            pbGrayScale.Refresh();
        }

        private void tsmiGrayScaleHSB_Click(object sender, EventArgs e)
        {
            Bitmaps.DoGrayScale(GrayScale.HSB);
            pbGrayScale.Refresh();
        }

        private void tsmiGrayScaleHSL_Click(object sender, EventArgs e)
        {
            Bitmaps.DoGrayScale(GrayScale.HSL);
            pbGrayScale.Refresh();
        }

        private void tsmiGrayScaleXYZ_Click(object sender, EventArgs e)
        {
            Bitmaps.DoGrayScale(GrayScale.XYZ);
            pbGrayScale.Refresh();            
        }

        private void tsmiInversion_Click(object sender, EventArgs e)
        {
            Bitmaps.Transform(Transformations.Inversion);
            pbProcessed.Refresh();
        }

        private void tsmiLog10_Click(object sender, EventArgs e)
        {
            double c = Transformations.LogCoef(10);
            Bitmaps.Transform(r => Transformations.Log(r, 10, c));
            pbProcessed.Refresh();
        }

        private void tsmiLn_Click(object sender, EventArgs e)
        {
            double c = Transformations.LogCoef(Math.E);
            Bitmaps.Transform(r => Transformations.Log(r, Math.E, c));
            pbProcessed.Refresh();
        }

        private void tsmiPower_Click(object sender, EventArgs e)
        {
            var sGamma = Microsoft.VisualBasic.Interaction.InputBox("ВВедите параметр Гамма (0.05..20)", 
                "Степенное преобразование", "0.5");
            if (sGamma == "")
            {
                return;
            }
            double Gamma;
            if (!Double.TryParse(sGamma, NumberStyles.Float, CultureInfo.InvariantCulture, out Gamma))
            {
                MessageBox.Show("Нужно ввести число (десятичный разделитель - точка)");
                return;
            }
            if ((Gamma < 0.05) || (Gamma > 20))
            {
                MessageBox.Show("Число должно быть в диапазоне от 0.05 до 20");
                return;
            }
            double c = Transformations.PowerCoef(Gamma);
            Bitmaps.Transform(r => Transformations.Power(r, Gamma, c));
            pbProcessed.Refresh();
        }

        private void PaintPiecewiseLinearFunc(PaintEventArgs e, Point[] Func)
        {           
            e.Graphics.Clear(Color.White);
            e.Graphics.ResetTransform();
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.ScaleTransform(pnlGraphic.Width / (float)255.0, -pnlGraphic.Height / (float)255.0);
            e.Graphics.TranslateTransform(0, -255);
            e.Graphics.DrawLine(pen, new Point(0, 0), new Point(0, 255));
            e.Graphics.DrawLine(pen, new Point(0, 0), new Point(255, 0));
            e.Graphics.DrawLines(pen, Func);
        }

		private void tsmiPiecewiseLinear_Click(object sender, EventArgs e)
		{
			var Func = new Point[4];
			Func[0].X = 0;
			Func[0].Y = 50;
			Func[1].X = 150;
			Func[1].Y = 200;
			Func[2].X = 150;
			Func[2].Y = 150;
			Func[3].X = 256;
			Func[3].Y = 256;
			Bitmaps.Transform(r => Transformations.PiecewiseLinear(r, Func));
			pbProcessed.Refresh();
			ShowGraphic(EvtArgs => PaintPiecewiseLinearFunc(EvtArgs, Func));
		}

		private int QueryThreshold(String Title)
        {
            var sResult = Microsoft.VisualBasic.Interaction.InputBox("ВВедите пороговое значение (0..255)",
               Title, "127");
            if (sResult == "")
            {
                return -1;
            }
            int Result;
            if (!int.TryParse(sResult, out Result))
            {
                MessageBox.Show("Нужно ввести целое число");
                return -1;
            }
            if ((Result < 0) || (Result > 255))
            {
                MessageBox.Show("Число должно быть в диапазоне от 0 до 255");
                return -1;
            }
            return Result;
        }

        private void tsmiBinarization_Click(object sender, EventArgs e)
        {
            var Threshold = QueryThreshold("Бинаризация");
            if (Threshold < 0)
            {
                return;
            }
            Bitmaps.Transform(r => Transformations.Binarization(r, (byte)Threshold));
            pbProcessed.Refresh();
        }

        private void tsmiThreshold_Click(object sender, EventArgs e)
        {
            var Threshold = QueryThreshold("Пороговое преобразование");
            if (Threshold < 0)
            {
                return;
            }        
            var Func = new Point[] {
                new Point {X = 0, Y = 85}, 
                new Point {X = Threshold, Y = 85}, 
                new Point {X = Threshold, Y = 170}, 
                new Point {X = 256, Y =  170}};
            Bitmaps.Transform(r => Transformations.PiecewiseLinear(r, Func));
            pbProcessed.Refresh();
        }

        private void tsmiBit_Click(object sender, EventArgs e)
        {
            var Bit = byte.Parse(((ToolStripMenuItem)sender).Tag.ToString());
            Bitmaps.Transform(r => Transformations.BitPlane(r, Bit));
            pbProcessed.Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var bm = new Bitmap(1, 1))
            {
                OpenImage(bm);   
            }
            MainForm_Resize(sender, e);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            pnlSource.Left = 0;
            pnlSource.Width = ClientSize.Width / 3;
            pnlGrayScale.Left = pnlSource.Left + pnlSource.Width;
            pnlGrayScale.Width = pnlSource.Width;
            pnlProcessed.Left = pnlGrayScale.Left + pnlGrayScale.Width;
            pnlProcessed.Width = pnlGrayScale.Width;
            pnlGraphic.Location = pnlSource.Location;
            pnlGraphic.Width = pnlSource.Width * 2;
            pnlGraphic.Height = pnlSource.Height;
            pnlGraphic.Invalidate();
        }

        private void Panel_Scroll(object sender, ScrollEventArgs e)
        {
            var Panel = (Panel)sender;
            pnlSource.VerticalScroll.Value = Panel.VerticalScroll.Value;
            pnlSource.HorizontalScroll.Value = Panel.HorizontalScroll.Value;
            pnlGrayScale.VerticalScroll.Value = Panel.VerticalScroll.Value;
            pnlGrayScale.HorizontalScroll.Value = Panel.HorizontalScroll.Value;
            pnlProcessed.VerticalScroll.Value = Panel.VerticalScroll.Value;
            pnlProcessed.HorizontalScroll.Value = Panel.HorizontalScroll.Value;
        }

        private void btnCloseGraphic_Click(object sender, EventArgs e)
        {
            pnlGraphic.Hide();
        }

        private void pnlGraphic_Paint(object sender, PaintEventArgs e)
        {
            graphicPainter(e);
        }

        private void tsmiEqualizeHistogram_Click(object sender, EventArgs e)
        {
            var Hist = Bitmaps.CalcHistogram(Rectangle.Empty);
            Histogram.Integrate(Hist);
            Bitmaps.Transform(r => Histogram.Apply(r, Hist));
            pbProcessed.Refresh();
        }

        private void tsmiLocalHistogramEqualization_Click(object sender, EventArgs e)
        {
            Bitmaps.LocalHistogramFilter(Histogram.LocalEqualization);
            pbProcessed.Refresh();
        }

        private void tsmiLocalHistogramChar_Click(object sender, EventArgs e)
        {
            var Hist = Bitmaps.CalcHistogram(Rectangle.Empty);
            double GlobalMean, GlobalVariance;
            Histogram.CalcChars(Hist, out GlobalMean, out GlobalVariance);
            Bitmaps.LocalHistogramFilter((r, h) => Histogram.LocalCharsFilter(r, h, GlobalMean, GlobalVariance));
            pbProcessed.Refresh();
        }

        private void tsmiAvgFilter_Click(object sender, EventArgs e)
        {
            Bitmaps.SpaceFilter(SpaceFilters.Avg);
            pbProcessed.Refresh();
        }

        private void tsmiWeightFilter_Click(object sender, EventArgs e)
        {
            Bitmaps.SpaceFilter(SpaceFilters.Weight);
            pbProcessed.Refresh();
        }

        private void tsmiGaussFilter_Click(object sender, EventArgs e)
        {
            //
        }

        private void tsmiMedianFilter_Click(object sender, EventArgs e)
        {
            Bitmaps.SpaceFilter(SpaceFilters.Median);
            pbProcessed.Refresh();
        }

        private void tsmiMinFilter_Click(object sender, EventArgs e)
        {
            Bitmaps.SpaceFilter(SpaceFilters.Min);
            pbProcessed.Refresh();
        }

        private void tsmiMaxFilter_Click(object sender, EventArgs e)
        {
            Bitmaps.SpaceFilter(SpaceFilters.Max);
            pbProcessed.Refresh();
        }

        private void tsmiLaplasian_Click(object sender, EventArgs e)
        {
            //
        }

        private void tsmiMasking_Click(object sender, EventArgs e)
        {
            //
        }

        private void tsmiSobel_Click(object sender, EventArgs e)
        {
            Bitmaps.SpaceFilter(SpaceFilters.Sobel);
            pbProcessed.Refresh();
        }

        private void tsmiRoberts_Click(object sender, EventArgs e)
        {
            Bitmaps.SpaceFilter(SpaceFilters.Roberts);
            pbProcessed.Refresh();
        }  
    }
}
