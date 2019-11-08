namespace ImageProcessing
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
			this.pnlSource = new System.Windows.Forms.Panel();
			this.pbSource = new System.Windows.Forms.PictureBox();
			this.pnlGrayScale = new System.Windows.Forms.Panel();
			this.pbGrayScale = new System.Windows.Forms.PictureBox();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.tsmiOpenImage = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiGrayScale = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiGrayScaleCartesian = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiGrayScaleHSI = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiGrayScaleHSB = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiGrayScaleHSL = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiGrayScaleXYZ = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTransformations = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiInversion = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLog10 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLn = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPower = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPiecewiseLinear = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBinarization = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiThreshold = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBits = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBit0 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBit1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBit2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBit3 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBit4 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBit5 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBit6 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBit7 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHistogram = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEqualizeHistogram = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLocalHistogramEqualization = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLocalHistogramChar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSpaceMethods = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAvgFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiWeightFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiGaussFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiMedianFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiMinFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiMaxFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLaplasian = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiMasking = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSobel = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiRoberts = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlProcessed = new System.Windows.Forms.Panel();
			this.pbProcessed = new System.Windows.Forms.PictureBox();
			this.pnlGraphic = new System.Windows.Forms.Panel();
			this.btnCloseGraphic = new System.Windows.Forms.Button();
			this.pnlSource.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
			this.pnlGrayScale.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbGrayScale)).BeginInit();
			this.MenuStrip.SuspendLayout();
			this.pnlProcessed.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProcessed)).BeginInit();
			this.pnlGraphic.SuspendLayout();
			this.SuspendLayout();
			// 
			// ofdOpenImage
			// 
			this.ofdOpenImage.FileName = "openFileDialog1";
			this.ofdOpenImage.Filter = "BMP|*.bmp|JPEG|*.jpg";
			// 
			// pnlSource
			// 
			this.pnlSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlSource.AutoScroll = true;
			this.pnlSource.Controls.Add(this.pbSource);
			this.pnlSource.Location = new System.Drawing.Point(3, 34);
			this.pnlSource.Margin = new System.Windows.Forms.Padding(4);
			this.pnlSource.Name = "pnlSource";
			this.pnlSource.Size = new System.Drawing.Size(163, 240);
			this.pnlSource.TabIndex = 0;
			this.pnlSource.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Panel_Scroll);
			// 
			// pbSource
			// 
			this.pbSource.Location = new System.Drawing.Point(0, 0);
			this.pbSource.Margin = new System.Windows.Forms.Padding(4);
			this.pbSource.Name = "pbSource";
			this.pbSource.Size = new System.Drawing.Size(79, 63);
			this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbSource.TabIndex = 0;
			this.pbSource.TabStop = false;
			// 
			// pnlGrayScale
			// 
			this.pnlGrayScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlGrayScale.AutoScroll = true;
			this.pnlGrayScale.Controls.Add(this.pbGrayScale);
			this.pnlGrayScale.Location = new System.Drawing.Point(189, 34);
			this.pnlGrayScale.Margin = new System.Windows.Forms.Padding(4);
			this.pnlGrayScale.Name = "pnlGrayScale";
			this.pnlGrayScale.Size = new System.Drawing.Size(144, 240);
			this.pnlGrayScale.TabIndex = 2;
			this.pnlGrayScale.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Panel_Scroll);
			// 
			// pbGrayScale
			// 
			this.pbGrayScale.Location = new System.Drawing.Point(0, 0);
			this.pbGrayScale.Margin = new System.Windows.Forms.Padding(4);
			this.pbGrayScale.Name = "pbGrayScale";
			this.pbGrayScale.Size = new System.Drawing.Size(79, 63);
			this.pbGrayScale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbGrayScale.TabIndex = 0;
			this.pbGrayScale.TabStop = false;
			// 
			// MenuStrip
			// 
			this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenImage,
            this.tsmiGrayScale,
            this.tsmiTransformations,
            this.tsmiHistogram,
            this.tsmiSpaceMethods});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.MenuStrip.Size = new System.Drawing.Size(865, 28);
			this.MenuStrip.TabIndex = 3;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// tsmiOpenImage
			// 
			this.tsmiOpenImage.Name = "tsmiOpenImage";
			this.tsmiOpenImage.Size = new System.Drawing.Size(181, 24);
			this.tsmiOpenImage.Text = "Открыть изображение";
			this.tsmiOpenImage.Click += new System.EventHandler(this.tsmiOpenImage_Click);
			// 
			// tsmiGrayScale
			// 
			this.tsmiGrayScale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGrayScaleCartesian,
            this.tsmiGrayScaleHSI,
            this.tsmiGrayScaleHSB,
            this.tsmiGrayScaleHSL,
            this.tsmiGrayScaleXYZ});
			this.tsmiGrayScale.Name = "tsmiGrayScale";
			this.tsmiGrayScale.Size = new System.Drawing.Size(142, 24);
			this.tsmiGrayScale.Text = "Градации серого";
			// 
			// tsmiGrayScaleCartesian
			// 
			this.tsmiGrayScaleCartesian.Name = "tsmiGrayScaleCartesian";
			this.tsmiGrayScaleCartesian.Size = new System.Drawing.Size(313, 26);
			this.tsmiGrayScaleCartesian.Text = "s = c * sqrt(r^2 + g^2 + b^2)";
			this.tsmiGrayScaleCartesian.Click += new System.EventHandler(this.tsmiGrayScaleCartesian_Click);
			// 
			// tsmiGrayScaleHSI
			// 
			this.tsmiGrayScaleHSI.Name = "tsmiGrayScaleHSI";
			this.tsmiGrayScaleHSI.Size = new System.Drawing.Size(313, 26);
			this.tsmiGrayScaleHSI.Text = "s = (r + g + b) / 3";
			this.tsmiGrayScaleHSI.Click += new System.EventHandler(this.tsmiGrayScaleHSI_Click);
			// 
			// tsmiGrayScaleHSB
			// 
			this.tsmiGrayScaleHSB.Name = "tsmiGrayScaleHSB";
			this.tsmiGrayScaleHSB.Size = new System.Drawing.Size(313, 26);
			this.tsmiGrayScaleHSB.Text = "s = max(r, g, b)";
			this.tsmiGrayScaleHSB.Click += new System.EventHandler(this.tsmiGrayScaleHSB_Click);
			// 
			// tsmiGrayScaleHSL
			// 
			this.tsmiGrayScaleHSL.Name = "tsmiGrayScaleHSL";
			this.tsmiGrayScaleHSL.Size = new System.Drawing.Size(313, 26);
			this.tsmiGrayScaleHSL.Text = "s = (max(r, g, b) + min(r, g, b)) / 2";
			this.tsmiGrayScaleHSL.Click += new System.EventHandler(this.tsmiGrayScaleHSL_Click);
			// 
			// tsmiGrayScaleXYZ
			// 
			this.tsmiGrayScaleXYZ.Name = "tsmiGrayScaleXYZ";
			this.tsmiGrayScaleXYZ.Size = new System.Drawing.Size(313, 26);
			this.tsmiGrayScaleXYZ.Text = "s = 0,213r + 0,715g + 0,072b";
			this.tsmiGrayScaleXYZ.Click += new System.EventHandler(this.tsmiGrayScaleXYZ_Click);
			// 
			// tsmiTransformations
			// 
			this.tsmiTransformations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInversion,
            this.tsmiLog10,
            this.tsmiLn,
            this.tsmiPower,
            this.tsmiPiecewiseLinear,
            this.tsmiBinarization,
            this.tsmiThreshold,
            this.tsmiBits});
			this.tsmiTransformations.Name = "tsmiTransformations";
			this.tsmiTransformations.Size = new System.Drawing.Size(144, 24);
			this.tsmiTransformations.Text = "Преобразования";
			// 
			// tsmiInversion
			// 
			this.tsmiInversion.Name = "tsmiInversion";
			this.tsmiInversion.Size = new System.Drawing.Size(370, 26);
			this.tsmiInversion.Text = "Негатив";
			this.tsmiInversion.Click += new System.EventHandler(this.tsmiInversion_Click);
			// 
			// tsmiLog10
			// 
			this.tsmiLog10.Name = "tsmiLog10";
			this.tsmiLog10.Size = new System.Drawing.Size(370, 26);
			this.tsmiLog10.Text = "Логарифмическое преобразования (lg)";
			this.tsmiLog10.Click += new System.EventHandler(this.tsmiLog10_Click);
			// 
			// tsmiLn
			// 
			this.tsmiLn.Name = "tsmiLn";
			this.tsmiLn.Size = new System.Drawing.Size(370, 26);
			this.tsmiLn.Text = "Логарифмическое преобразование (ln)";
			this.tsmiLn.Click += new System.EventHandler(this.tsmiLn_Click);
			// 
			// tsmiPower
			// 
			this.tsmiPower.Name = "tsmiPower";
			this.tsmiPower.Size = new System.Drawing.Size(370, 26);
			this.tsmiPower.Text = "Степенное преобразование";
			this.tsmiPower.Click += new System.EventHandler(this.tsmiPower_Click);
			// 
			// tsmiPiecewiseLinear
			// 
			this.tsmiPiecewiseLinear.Name = "tsmiPiecewiseLinear";
			this.tsmiPiecewiseLinear.Size = new System.Drawing.Size(370, 26);
			this.tsmiPiecewiseLinear.Text = "Кусочно-линейная фильтрация";
			this.tsmiPiecewiseLinear.Click += new System.EventHandler(this.tsmiPiecewiseLinear_Click);
			// 
			// tsmiBinarization
			// 
			this.tsmiBinarization.Name = "tsmiBinarization";
			this.tsmiBinarization.Size = new System.Drawing.Size(370, 26);
			this.tsmiBinarization.Text = "Бинаризация";
			this.tsmiBinarization.Click += new System.EventHandler(this.tsmiBinarization_Click);
			// 
			// tsmiThreshold
			// 
			this.tsmiThreshold.Name = "tsmiThreshold";
			this.tsmiThreshold.Size = new System.Drawing.Size(370, 26);
			this.tsmiThreshold.Text = "Пороговое преобразование";
			this.tsmiThreshold.Click += new System.EventHandler(this.tsmiThreshold_Click);
			// 
			// tsmiBits
			// 
			this.tsmiBits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBit0,
            this.tsmiBit1,
            this.tsmiBit2,
            this.tsmiBit3,
            this.tsmiBit4,
            this.tsmiBit5,
            this.tsmiBit6,
            this.tsmiBit7});
			this.tsmiBits.Name = "tsmiBits";
			this.tsmiBits.Size = new System.Drawing.Size(370, 26);
			this.tsmiBits.Text = "Срез битовой плоскости";
			// 
			// tsmiBit0
			// 
			this.tsmiBit0.Name = "tsmiBit0";
			this.tsmiBit0.Size = new System.Drawing.Size(207, 26);
			this.tsmiBit0.Tag = "0";
			this.tsmiBit0.Text = "Бит 0 (младший)";
			this.tsmiBit0.Click += new System.EventHandler(this.tsmiBit_Click);
			// 
			// tsmiBit1
			// 
			this.tsmiBit1.Name = "tsmiBit1";
			this.tsmiBit1.Size = new System.Drawing.Size(207, 26);
			this.tsmiBit1.Tag = "1";
			this.tsmiBit1.Text = "Бит 1";
			this.tsmiBit1.Click += new System.EventHandler(this.tsmiBit_Click);
			// 
			// tsmiBit2
			// 
			this.tsmiBit2.Name = "tsmiBit2";
			this.tsmiBit2.Size = new System.Drawing.Size(207, 26);
			this.tsmiBit2.Tag = "2";
			this.tsmiBit2.Text = "Бит 2";
			this.tsmiBit2.Click += new System.EventHandler(this.tsmiBit_Click);
			// 
			// tsmiBit3
			// 
			this.tsmiBit3.Name = "tsmiBit3";
			this.tsmiBit3.Size = new System.Drawing.Size(207, 26);
			this.tsmiBit3.Tag = "3";
			this.tsmiBit3.Text = "Бит 3";
			this.tsmiBit3.Click += new System.EventHandler(this.tsmiBit_Click);
			// 
			// tsmiBit4
			// 
			this.tsmiBit4.Name = "tsmiBit4";
			this.tsmiBit4.Size = new System.Drawing.Size(207, 26);
			this.tsmiBit4.Tag = "4";
			this.tsmiBit4.Text = "Бит 4";
			this.tsmiBit4.Click += new System.EventHandler(this.tsmiBit_Click);
			// 
			// tsmiBit5
			// 
			this.tsmiBit5.Name = "tsmiBit5";
			this.tsmiBit5.Size = new System.Drawing.Size(207, 26);
			this.tsmiBit5.Tag = "5";
			this.tsmiBit5.Text = "Бит 5";
			this.tsmiBit5.Click += new System.EventHandler(this.tsmiBit_Click);
			// 
			// tsmiBit6
			// 
			this.tsmiBit6.Name = "tsmiBit6";
			this.tsmiBit6.Size = new System.Drawing.Size(207, 26);
			this.tsmiBit6.Tag = "6";
			this.tsmiBit6.Text = "Бит 6";
			this.tsmiBit6.Click += new System.EventHandler(this.tsmiBit_Click);
			// 
			// tsmiBit7
			// 
			this.tsmiBit7.Name = "tsmiBit7";
			this.tsmiBit7.Size = new System.Drawing.Size(207, 26);
			this.tsmiBit7.Tag = "7";
			this.tsmiBit7.Text = "Бит 7 (старший)";
			this.tsmiBit7.Click += new System.EventHandler(this.tsmiBit_Click);
			// 
			// tsmiHistogram
			// 
			this.tsmiHistogram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEqualizeHistogram,
            this.tsmiLocalHistogramEqualization,
            this.tsmiLocalHistogramChar});
			this.tsmiHistogram.Name = "tsmiHistogram";
			this.tsmiHistogram.Size = new System.Drawing.Size(114, 24);
			this.tsmiHistogram.Text = "Гистограмма";
			// 
			// tsmiEqualizeHistogram
			// 
			this.tsmiEqualizeHistogram.Name = "tsmiEqualizeHistogram";
			this.tsmiEqualizeHistogram.Size = new System.Drawing.Size(398, 26);
			this.tsmiEqualizeHistogram.Text = "Эквализация гистограммы";
			this.tsmiEqualizeHistogram.Click += new System.EventHandler(this.tsmiEqualizeHistogram_Click);
			// 
			// tsmiLocalHistogramEqualization
			// 
			this.tsmiLocalHistogramEqualization.Name = "tsmiLocalHistogramEqualization";
			this.tsmiLocalHistogramEqualization.Size = new System.Drawing.Size(398, 26);
			this.tsmiLocalHistogramEqualization.Text = "Локальная фильтрация";
			this.tsmiLocalHistogramEqualization.Click += new System.EventHandler(this.tsmiLocalHistogramEqualization_Click);
			// 
			// tsmiLocalHistogramChar
			// 
			this.tsmiLocalHistogramChar.Name = "tsmiLocalHistogramChar";
			this.tsmiLocalHistogramChar.Size = new System.Drawing.Size(398, 26);
			this.tsmiLocalHistogramChar.Text = "Улучшение по локальным характеристикам";
			this.tsmiLocalHistogramChar.Click += new System.EventHandler(this.tsmiLocalHistogramChar_Click);
			// 
			// tsmiSpaceMethods
			// 
			this.tsmiSpaceMethods.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAvgFilter,
            this.tsmiWeightFilter,
            this.tsmiGaussFilter,
            this.tsmiMedianFilter,
            this.tsmiMinFilter,
            this.tsmiMaxFilter,
            this.tsmiLaplasian,
            this.tsmiMasking,
            this.tsmiSobel,
            this.tsmiRoberts});
			this.tsmiSpaceMethods.Name = "tsmiSpaceMethods";
			this.tsmiSpaceMethods.Size = new System.Drawing.Size(214, 24);
			this.tsmiSpaceMethods.Text = "Пространственные методы";
			// 
			// tsmiAvgFilter
			// 
			this.tsmiAvgFilter.Name = "tsmiAvgFilter";
			this.tsmiAvgFilter.Size = new System.Drawing.Size(305, 26);
			this.tsmiAvgFilter.Text = "Фильтр среднего";
			this.tsmiAvgFilter.Click += new System.EventHandler(this.tsmiAvgFilter_Click);
			// 
			// tsmiWeightFilter
			// 
			this.tsmiWeightFilter.Name = "tsmiWeightFilter";
			this.tsmiWeightFilter.Size = new System.Drawing.Size(305, 26);
			this.tsmiWeightFilter.Text = "Фильтр средневзвешенного";
			this.tsmiWeightFilter.Click += new System.EventHandler(this.tsmiWeightFilter_Click);
			// 
			// tsmiGaussFilter
			// 
			this.tsmiGaussFilter.Name = "tsmiGaussFilter";
			this.tsmiGaussFilter.Size = new System.Drawing.Size(305, 26);
			this.tsmiGaussFilter.Text = "Фильтр Гаусса";
			this.tsmiGaussFilter.Click += new System.EventHandler(this.tsmiGaussFilter_Click);
			// 
			// tsmiMedianFilter
			// 
			this.tsmiMedianFilter.Name = "tsmiMedianFilter";
			this.tsmiMedianFilter.Size = new System.Drawing.Size(305, 26);
			this.tsmiMedianFilter.Text = "Медианный фильтр";
			this.tsmiMedianFilter.Click += new System.EventHandler(this.tsmiMedianFilter_Click);
			// 
			// tsmiMinFilter
			// 
			this.tsmiMinFilter.Name = "tsmiMinFilter";
			this.tsmiMinFilter.Size = new System.Drawing.Size(305, 26);
			this.tsmiMinFilter.Text = "Фильтр минимума";
			this.tsmiMinFilter.Click += new System.EventHandler(this.tsmiMinFilter_Click);
			// 
			// tsmiMaxFilter
			// 
			this.tsmiMaxFilter.Name = "tsmiMaxFilter";
			this.tsmiMaxFilter.Size = new System.Drawing.Size(305, 26);
			this.tsmiMaxFilter.Text = "Фильтр максимума";
			this.tsmiMaxFilter.Click += new System.EventHandler(this.tsmiMaxFilter_Click);
			// 
			// tsmiLaplasian
			// 
			this.tsmiLaplasian.Name = "tsmiLaplasian";
			this.tsmiLaplasian.Size = new System.Drawing.Size(305, 26);
			this.tsmiLaplasian.Text = "Лапласиан";
			this.tsmiLaplasian.Click += new System.EventHandler(this.tsmiLaplasian_Click);
			// 
			// tsmiMasking
			// 
			this.tsmiMasking.Name = "tsmiMasking";
			this.tsmiMasking.Size = new System.Drawing.Size(305, 26);
			this.tsmiMasking.Text = "Нерезкое маскирование";
			this.tsmiMasking.Click += new System.EventHandler(this.tsmiMasking_Click);
			// 
			// tsmiSobel
			// 
			this.tsmiSobel.Name = "tsmiSobel";
			this.tsmiSobel.Size = new System.Drawing.Size(305, 26);
			this.tsmiSobel.Text = "Оператор Собеля";
			this.tsmiSobel.Click += new System.EventHandler(this.tsmiSobel_Click);
			// 
			// tsmiRoberts
			// 
			this.tsmiRoberts.Name = "tsmiRoberts";
			this.tsmiRoberts.Size = new System.Drawing.Size(305, 26);
			this.tsmiRoberts.Text = "Линейный оператор Робертса";
			this.tsmiRoberts.Click += new System.EventHandler(this.tsmiRoberts_Click);
			// 
			// pnlProcessed
			// 
			this.pnlProcessed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlProcessed.AutoScroll = true;
			this.pnlProcessed.Controls.Add(this.pbProcessed);
			this.pnlProcessed.Location = new System.Drawing.Point(355, 34);
			this.pnlProcessed.Margin = new System.Windows.Forms.Padding(4);
			this.pnlProcessed.Name = "pnlProcessed";
			this.pnlProcessed.Size = new System.Drawing.Size(145, 240);
			this.pnlProcessed.TabIndex = 4;
			this.pnlProcessed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Panel_Scroll);
			// 
			// pbProcessed
			// 
			this.pbProcessed.Location = new System.Drawing.Point(0, 0);
			this.pbProcessed.Margin = new System.Windows.Forms.Padding(4);
			this.pbProcessed.Name = "pbProcessed";
			this.pbProcessed.Size = new System.Drawing.Size(79, 63);
			this.pbProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbProcessed.TabIndex = 0;
			this.pbProcessed.TabStop = false;
			// 
			// pnlGraphic
			// 
			this.pnlGraphic.Controls.Add(this.btnCloseGraphic);
			this.pnlGraphic.Location = new System.Drawing.Point(537, 52);
			this.pnlGraphic.Margin = new System.Windows.Forms.Padding(4);
			this.pnlGraphic.Name = "pnlGraphic";
			this.pnlGraphic.Size = new System.Drawing.Size(249, 208);
			this.pnlGraphic.TabIndex = 5;
			this.pnlGraphic.Visible = false;
			this.pnlGraphic.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraphic_Paint);
			// 
			// btnCloseGraphic
			// 
			this.btnCloseGraphic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCloseGraphic.Location = new System.Drawing.Point(83, 4);
			this.btnCloseGraphic.Margin = new System.Windows.Forms.Padding(4);
			this.btnCloseGraphic.Name = "btnCloseGraphic";
			this.btnCloseGraphic.Size = new System.Drawing.Size(163, 28);
			this.btnCloseGraphic.TabIndex = 0;
			this.btnCloseGraphic.Text = "Закрыть график";
			this.btnCloseGraphic.UseVisualStyleBackColor = true;
			this.btnCloseGraphic.Click += new System.EventHandler(this.btnCloseGraphic_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 274);
			this.Controls.Add(this.pnlGraphic);
			this.Controls.Add(this.pnlProcessed);
			this.Controls.Add(this.pnlGrayScale);
			this.Controls.Add(this.pnlSource);
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.pnlSource.ResumeLayout(false);
			this.pnlSource.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
			this.pnlGrayScale.ResumeLayout(false);
			this.pnlGrayScale.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbGrayScale)).EndInit();
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.pnlProcessed.ResumeLayout(false);
			this.pnlProcessed.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProcessed)).EndInit();
			this.pnlGraphic.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.Panel pnlSource;
        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.Panel pnlGrayScale;
        private System.Windows.Forms.PictureBox pbGrayScale;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrayScale;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrayScaleCartesian;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrayScaleHSI;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrayScaleHSB;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrayScaleHSL;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrayScaleXYZ;
        private System.Windows.Forms.ToolStripMenuItem tsmiTransformations;
        private System.Windows.Forms.ToolStripMenuItem tsmiInversion;
        private System.Windows.Forms.Panel pnlProcessed;
        private System.Windows.Forms.PictureBox pbProcessed;
        private System.Windows.Forms.ToolStripMenuItem tsmiLog10;
        private System.Windows.Forms.ToolStripMenuItem tsmiLn;
        private System.Windows.Forms.ToolStripMenuItem tsmiPower;
        private System.Windows.Forms.ToolStripMenuItem tsmiPiecewiseLinear;
        private System.Windows.Forms.ToolStripMenuItem tsmiBinarization;
        private System.Windows.Forms.ToolStripMenuItem tsmiThreshold;
        private System.Windows.Forms.ToolStripMenuItem tsmiBits;
        private System.Windows.Forms.ToolStripMenuItem tsmiBit0;
        private System.Windows.Forms.ToolStripMenuItem tsmiBit1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBit2;
        private System.Windows.Forms.ToolStripMenuItem tsmiBit3;
        private System.Windows.Forms.ToolStripMenuItem tsmiBit4;
        private System.Windows.Forms.ToolStripMenuItem tsmiBit5;
        private System.Windows.Forms.ToolStripMenuItem tsmiBit6;
        private System.Windows.Forms.ToolStripMenuItem tsmiBit7;
        private System.Windows.Forms.Panel pnlGraphic;
        private System.Windows.Forms.Button btnCloseGraphic;
        private System.Windows.Forms.ToolStripMenuItem tsmiHistogram;
        private System.Windows.Forms.ToolStripMenuItem tsmiEqualizeHistogram;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalHistogramEqualization;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalHistogramChar;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpaceMethods;
        private System.Windows.Forms.ToolStripMenuItem tsmiAvgFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiWeightFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiGaussFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiMedianFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaxFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiLaplasian;
        private System.Windows.Forms.ToolStripMenuItem tsmiMasking;
        private System.Windows.Forms.ToolStripMenuItem tsmiSobel;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoberts;
    }
}

