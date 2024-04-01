namespace App
{
    partial class Encryptor
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encryptor));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tbInitText = new System.Windows.Forms.TextBox();
            this.lbKey = new System.Windows.Forms.Label();
            this.butEncrypt = new System.Windows.Forms.Button();
            this.lbInitialization = new System.Windows.Forms.Label();
            this.lbInitText = new System.Windows.Forms.Label();
            this.lbCipherText = new System.Windows.Forms.Label();
            this.cbInitialization = new System.Windows.Forms.ComboBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbCiphertext = new System.Windows.Forms.TextBox();
            this.butOpenInitText = new System.Windows.Forms.Button();
            this.butSaveInitText = new System.Windows.Forms.Button();
            this.butSaveCiphertext = new System.Windows.Forms.Button();
            this.butOpenCiphertext = new System.Windows.Forms.Button();
            this.butDecrypt = new System.Windows.Forms.Button();
            this.tbInitTextFileName = new System.Windows.Forms.TextBox();
            this.tbCiphertextFileName = new System.Windows.Forms.TextBox();
            this.lbErrors = new System.Windows.Forms.Label();
            this.tbErrors = new System.Windows.Forms.TextBox();
            this.butSaveAsCiphertext = new System.Windows.Forms.Button();
            this.butSaveAsInitText = new System.Windows.Forms.Button();
            this.butNewCiphertext = new System.Windows.Forms.Button();
            this.butNewInitText = new System.Windows.Forms.Button();
            this.butResetCiphertext = new System.Windows.Forms.Button();
            this.butResetInitText = new System.Windows.Forms.Button();
            this.chInitText = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chCiphertext = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chSaveAsCiphertext = new System.Windows.Forms.Button();
            this.chSaveCiphertext = new System.Windows.Forms.Button();
            this.chSaveAsInitText = new System.Windows.Forms.Button();
            this.chSaveInitText = new System.Windows.Forms.Button();
            this.tbChartInitText = new System.Windows.Forms.TextBox();
            this.tbChartCiphertext = new System.Windows.Forms.TextBox();
            this.butRunTests = new System.Windows.Forms.Button();
            this.tbBlockSz = new System.Windows.Forms.TextBox();
            this.tbMatrixQ = new System.Windows.Forms.TextBox();
            this.tbMatrixM = new System.Windows.Forms.TextBox();
            this.lbBlockSz = new System.Windows.Forms.Label();
            this.lbMatrixRows = new System.Windows.Forms.Label();
            this.lbFreqTest = new System.Windows.Forms.Label();
            this.tbFreqTest = new System.Windows.Forms.TextBox();
            this.tbLROTest = new System.Windows.Forms.TextBox();
            this.lbLROTest = new System.Windows.Forms.Label();
            this.lbRankTest = new System.Windows.Forms.Label();
            this.tbRankTest = new System.Windows.Forms.TextBox();
            this.lbBlockFreqTest = new System.Windows.Forms.Label();
            this.tbBlockFreqTest = new System.Windows.Forms.TextBox();
            this.lbDFTTest = new System.Windows.Forms.Label();
            this.tbDFTTest = new System.Windows.Forms.TextBox();
            this.lbRunsTest = new System.Windows.Forms.Label();
            this.tbRunsTest = new System.Windows.Forms.TextBox();
            this.lbMatrixColumns = new System.Windows.Forms.Label();
            this.tbKeyA51 = new System.Windows.Forms.TextBox();
            this.tbKeyLength = new System.Windows.Forms.TextBox();
            this.lbKeyLength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chInitText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCiphertext)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInitText
            // 
            this.tbInitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInitText.Location = new System.Drawing.Point(12, 45);
            this.tbInitText.Multiline = true;
            this.tbInitText.Name = "tbInitText";
            this.tbInitText.ReadOnly = true;
            this.tbInitText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInitText.Size = new System.Drawing.Size(323, 105);
            this.tbInitText.TabIndex = 1;
            // 
            // lbKey
            // 
            this.lbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbKey.Location = new System.Drawing.Point(130, 307);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(203, 23);
            this.lbKey.TabIndex = 6;
            this.lbKey.Text = "Key (0...18446744073709551615):";
            this.lbKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butEncrypt
            // 
            this.butEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEncrypt.Location = new System.Drawing.Point(12, 489);
            this.butEncrypt.Name = "butEncrypt";
            this.butEncrypt.Size = new System.Drawing.Size(158, 29);
            this.butEncrypt.TabIndex = 7;
            this.butEncrypt.Text = "Encrypt";
            this.butEncrypt.UseVisualStyleBackColor = true;
            this.butEncrypt.Click += new System.EventHandler(this.butEncrypt_Click);
            // 
            // lbInitialization
            // 
            this.lbInitialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInitialization.Location = new System.Drawing.Point(12, 307);
            this.lbInitialization.Name = "lbInitialization";
            this.lbInitialization.Size = new System.Drawing.Size(68, 23);
            this.lbInitialization.TabIndex = 10;
            this.lbInitialization.Text = "Initialization:";
            this.lbInitialization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbInitText
            // 
            this.lbInitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInitText.Location = new System.Drawing.Point(12, 9);
            this.lbInitText.Name = "lbInitText";
            this.lbInitText.Size = new System.Drawing.Size(300, 33);
            this.lbInitText.TabIndex = 11;
            this.lbInitText.Text = "Initial text:";
            this.lbInitText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCipherText
            // 
            this.lbCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCipherText.Location = new System.Drawing.Point(12, 153);
            this.lbCipherText.Name = "lbCipherText";
            this.lbCipherText.Size = new System.Drawing.Size(300, 33);
            this.lbCipherText.TabIndex = 13;
            this.lbCipherText.Text = "Ciphertext:";
            this.lbCipherText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbInitialization
            // 
            this.cbInitialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInitialization.FormattingEnabled = true;
            this.cbInitialization.Items.AddRange(new object[] { "First Version", "Second Version" });
            this.cbInitialization.Location = new System.Drawing.Point(12, 333);
            this.cbInitialization.Name = "cbInitialization";
            this.cbInitialization.Size = new System.Drawing.Size(97, 21);
            this.cbInitialization.TabIndex = 14;
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey.Location = new System.Drawing.Point(130, 333);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(204, 22);
            this.tbKey.TabIndex = 15;
            // 
            // tbCiphertext
            // 
            this.tbCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCiphertext.Location = new System.Drawing.Point(12, 189);
            this.tbCiphertext.Multiline = true;
            this.tbCiphertext.Name = "tbCiphertext";
            this.tbCiphertext.ReadOnly = true;
            this.tbCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCiphertext.Size = new System.Drawing.Size(323, 105);
            this.tbCiphertext.TabIndex = 16;
            // 
            // butOpenInitText
            // 
            this.butOpenInitText.Image = ((System.Drawing.Image)(resources.GetObject("butOpenInitText.Image")));
            this.butOpenInitText.Location = new System.Drawing.Point(218, 17);
            this.butOpenInitText.Name = "butOpenInitText";
            this.butOpenInitText.Size = new System.Drawing.Size(25, 25);
            this.butOpenInitText.TabIndex = 17;
            this.butOpenInitText.UseVisualStyleBackColor = true;
            this.butOpenInitText.Click += new System.EventHandler(this.butOpenInitText_Click);
            // 
            // butSaveInitText
            // 
            this.butSaveInitText.Image = ((System.Drawing.Image)(resources.GetObject("butSaveInitText.Image")));
            this.butSaveInitText.Location = new System.Drawing.Point(247, 17);
            this.butSaveInitText.Name = "butSaveInitText";
            this.butSaveInitText.Size = new System.Drawing.Size(25, 25);
            this.butSaveInitText.TabIndex = 18;
            this.butSaveInitText.UseVisualStyleBackColor = true;
            this.butSaveInitText.Click += new System.EventHandler(this.butSaveInitText_Click);
            // 
            // butSaveCiphertext
            // 
            this.butSaveCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("butSaveCiphertext.Image")));
            this.butSaveCiphertext.Location = new System.Drawing.Point(249, 161);
            this.butSaveCiphertext.Name = "butSaveCiphertext";
            this.butSaveCiphertext.Size = new System.Drawing.Size(25, 25);
            this.butSaveCiphertext.TabIndex = 20;
            this.butSaveCiphertext.UseVisualStyleBackColor = true;
            this.butSaveCiphertext.Click += new System.EventHandler(this.butSaveCiphertext_Click);
            // 
            // butOpenCiphertext
            // 
            this.butOpenCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("butOpenCiphertext.Image")));
            this.butOpenCiphertext.Location = new System.Drawing.Point(218, 161);
            this.butOpenCiphertext.Name = "butOpenCiphertext";
            this.butOpenCiphertext.Size = new System.Drawing.Size(25, 25);
            this.butOpenCiphertext.TabIndex = 19;
            this.butOpenCiphertext.UseVisualStyleBackColor = true;
            this.butOpenCiphertext.Click += new System.EventHandler(this.butOpenCiphertext_Click);
            // 
            // butDecrypt
            // 
            this.butDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDecrypt.Location = new System.Drawing.Point(176, 489);
            this.butDecrypt.Name = "butDecrypt";
            this.butDecrypt.Size = new System.Drawing.Size(158, 29);
            this.butDecrypt.TabIndex = 21;
            this.butDecrypt.Text = "Decrypt";
            this.butDecrypt.UseVisualStyleBackColor = true;
            this.butDecrypt.Click += new System.EventHandler(this.butDecrypt_Click);
            // 
            // tbInitTextFileName
            // 
            this.tbInitTextFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInitTextFileName.Location = new System.Drawing.Point(80, 14);
            this.tbInitTextFileName.Name = "tbInitTextFileName";
            this.tbInitTextFileName.ReadOnly = true;
            this.tbInitTextFileName.Size = new System.Drawing.Size(103, 22);
            this.tbInitTextFileName.TabIndex = 24;
            // 
            // tbCiphertextFileName
            // 
            this.tbCiphertextFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCiphertextFileName.Location = new System.Drawing.Point(80, 158);
            this.tbCiphertextFileName.Name = "tbCiphertextFileName";
            this.tbCiphertextFileName.ReadOnly = true;
            this.tbCiphertextFileName.Size = new System.Drawing.Size(103, 22);
            this.tbCiphertextFileName.TabIndex = 25;
            // 
            // lbErrors
            // 
            this.lbErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbErrors.Location = new System.Drawing.Point(605, 315);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(45, 17);
            this.lbErrors.TabIndex = 8;
            this.lbErrors.Text = "Errors:";
            this.lbErrors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbErrors
            // 
            this.tbErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbErrors.Location = new System.Drawing.Point(605, 335);
            this.tbErrors.Multiline = true;
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.ReadOnly = true;
            this.tbErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbErrors.Size = new System.Drawing.Size(323, 181);
            this.tbErrors.TabIndex = 9;
            // 
            // butSaveAsCiphertext
            // 
            this.butSaveAsCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("butSaveAsCiphertext.Image")));
            this.butSaveAsCiphertext.Location = new System.Drawing.Point(280, 161);
            this.butSaveAsCiphertext.Name = "butSaveAsCiphertext";
            this.butSaveAsCiphertext.Size = new System.Drawing.Size(25, 25);
            this.butSaveAsCiphertext.TabIndex = 26;
            this.butSaveAsCiphertext.UseVisualStyleBackColor = true;
            this.butSaveAsCiphertext.Click += new System.EventHandler(this.butSaveAsCiphertext_Click);
            // 
            // butSaveAsInitText
            // 
            this.butSaveAsInitText.Image = ((System.Drawing.Image)(resources.GetObject("butSaveAsInitText.Image")));
            this.butSaveAsInitText.Location = new System.Drawing.Point(278, 17);
            this.butSaveAsInitText.Name = "butSaveAsInitText";
            this.butSaveAsInitText.Size = new System.Drawing.Size(25, 25);
            this.butSaveAsInitText.TabIndex = 27;
            this.butSaveAsInitText.UseVisualStyleBackColor = true;
            this.butSaveAsInitText.Click += new System.EventHandler(this.butSaveAsInitText_Click);
            // 
            // butNewCiphertext
            // 
            this.butNewCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("butNewCiphertext.Image")));
            this.butNewCiphertext.Location = new System.Drawing.Point(188, 161);
            this.butNewCiphertext.Name = "butNewCiphertext";
            this.butNewCiphertext.Size = new System.Drawing.Size(25, 25);
            this.butNewCiphertext.TabIndex = 28;
            this.butNewCiphertext.UseVisualStyleBackColor = true;
            this.butNewCiphertext.Click += new System.EventHandler(this.butNewCiphertext_Click);
            // 
            // butNewInitText
            // 
            this.butNewInitText.Image = ((System.Drawing.Image)(resources.GetObject("butNewInitText.Image")));
            this.butNewInitText.Location = new System.Drawing.Point(188, 17);
            this.butNewInitText.Name = "butNewInitText";
            this.butNewInitText.Size = new System.Drawing.Size(25, 25);
            this.butNewInitText.TabIndex = 29;
            this.butNewInitText.UseVisualStyleBackColor = true;
            this.butNewInitText.Click += new System.EventHandler(this.butNewInitText_Click);
            // 
            // butResetCiphertext
            // 
            this.butResetCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("butResetCiphertext.Image")));
            this.butResetCiphertext.Location = new System.Drawing.Point(309, 161);
            this.butResetCiphertext.Name = "butResetCiphertext";
            this.butResetCiphertext.Size = new System.Drawing.Size(25, 25);
            this.butResetCiphertext.TabIndex = 34;
            this.butResetCiphertext.UseVisualStyleBackColor = true;
            this.butResetCiphertext.Click += new System.EventHandler(this.butResetCiphertext_Click);
            // 
            // butResetInitText
            // 
            this.butResetInitText.Image = ((System.Drawing.Image)(resources.GetObject("butResetInitText.Image")));
            this.butResetInitText.Location = new System.Drawing.Point(309, 17);
            this.butResetInitText.Name = "butResetInitText";
            this.butResetInitText.Size = new System.Drawing.Size(25, 25);
            this.butResetInitText.TabIndex = 35;
            this.butResetInitText.UseVisualStyleBackColor = true;
            this.butResetInitText.Click += new System.EventHandler(this.butResetInitText_Click);
            // 
            // chInitText
            // 
            chartArea1.Name = "ChartArea1";
            this.chInitText.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chInitText.Legends.Add(legend1);
            this.chInitText.Location = new System.Drawing.Point(605, 45);
            this.chInitText.Margin = new System.Windows.Forms.Padding(2);
            this.chInitText.Name = "chInitText";
            this.chInitText.Size = new System.Drawing.Size(322, 104);
            this.chInitText.TabIndex = 36;
            // 
            // chCiphertext
            // 
            chartArea2.Name = "ChartArea1";
            this.chCiphertext.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chCiphertext.Legends.Add(legend2);
            this.chCiphertext.Location = new System.Drawing.Point(605, 189);
            this.chCiphertext.Margin = new System.Windows.Forms.Padding(2);
            this.chCiphertext.Name = "chCiphertext";
            this.chCiphertext.Size = new System.Drawing.Size(322, 104);
            this.chCiphertext.TabIndex = 37;
            // 
            // chSaveAsCiphertext
            // 
            this.chSaveAsCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("chSaveAsCiphertext.Image")));
            this.chSaveAsCiphertext.Location = new System.Drawing.Point(902, 161);
            this.chSaveAsCiphertext.Name = "chSaveAsCiphertext";
            this.chSaveAsCiphertext.Size = new System.Drawing.Size(25, 25);
            this.chSaveAsCiphertext.TabIndex = 39;
            this.chSaveAsCiphertext.UseVisualStyleBackColor = true;
            this.chSaveAsCiphertext.Click += new System.EventHandler(this.chSaveAsCiphertext_Click);
            // 
            // chSaveCiphertext
            // 
            this.chSaveCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("chSaveCiphertext.Image")));
            this.chSaveCiphertext.Location = new System.Drawing.Point(872, 161);
            this.chSaveCiphertext.Name = "chSaveCiphertext";
            this.chSaveCiphertext.Size = new System.Drawing.Size(25, 25);
            this.chSaveCiphertext.TabIndex = 38;
            this.chSaveCiphertext.UseVisualStyleBackColor = true;
            this.chSaveCiphertext.Click += new System.EventHandler(this.chSaveCiphertext_Click);
            // 
            // chSaveAsInitText
            // 
            this.chSaveAsInitText.Image = ((System.Drawing.Image)(resources.GetObject("chSaveAsInitText.Image")));
            this.chSaveAsInitText.Location = new System.Drawing.Point(902, 17);
            this.chSaveAsInitText.Name = "chSaveAsInitText";
            this.chSaveAsInitText.Size = new System.Drawing.Size(25, 25);
            this.chSaveAsInitText.TabIndex = 41;
            this.chSaveAsInitText.UseVisualStyleBackColor = true;
            this.chSaveAsInitText.Click += new System.EventHandler(this.chSaveAsInitText_Click);
            // 
            // chSaveInitText
            // 
            this.chSaveInitText.Image = ((System.Drawing.Image)(resources.GetObject("chSaveInitText.Image")));
            this.chSaveInitText.Location = new System.Drawing.Point(872, 17);
            this.chSaveInitText.Name = "chSaveInitText";
            this.chSaveInitText.Size = new System.Drawing.Size(25, 25);
            this.chSaveInitText.TabIndex = 40;
            this.chSaveInitText.UseVisualStyleBackColor = true;
            this.chSaveInitText.Click += new System.EventHandler(this.chSaveInitText_Click);
            // 
            // tbChartInitText
            // 
            this.tbChartInitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChartInitText.Location = new System.Drawing.Point(764, 20);
            this.tbChartInitText.Name = "tbChartInitText";
            this.tbChartInitText.ReadOnly = true;
            this.tbChartInitText.Size = new System.Drawing.Size(103, 22);
            this.tbChartInitText.TabIndex = 42;
            // 
            // tbChartCiphertext
            // 
            this.tbChartCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChartCiphertext.Location = new System.Drawing.Point(764, 164);
            this.tbChartCiphertext.Name = "tbChartCiphertext";
            this.tbChartCiphertext.ReadOnly = true;
            this.tbChartCiphertext.Size = new System.Drawing.Size(103, 22);
            this.tbChartCiphertext.TabIndex = 43;
            // 
            // butRunTests
            // 
            this.butRunTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butRunTests.Location = new System.Drawing.Point(340, 487);
            this.butRunTests.Name = "butRunTests";
            this.butRunTests.Size = new System.Drawing.Size(260, 29);
            this.butRunTests.TabIndex = 44;
            this.butRunTests.Text = "Run Tests";
            this.butRunTests.UseVisualStyleBackColor = true;
            this.butRunTests.Click += new System.EventHandler(this.butRunTests_Click);
            // 
            // tbBlockSz
            // 
            this.tbBlockSz.Location = new System.Drawing.Point(343, 407);
            this.tbBlockSz.Margin = new System.Windows.Forms.Padding(2);
            this.tbBlockSz.Name = "tbBlockSz";
            this.tbBlockSz.Size = new System.Drawing.Size(121, 20);
            this.tbBlockSz.TabIndex = 45;
            // 
            // tbMatrixQ
            // 
            this.tbMatrixQ.Location = new System.Drawing.Point(476, 454);
            this.tbMatrixQ.Margin = new System.Windows.Forms.Padding(2);
            this.tbMatrixQ.Name = "tbMatrixQ";
            this.tbMatrixQ.Size = new System.Drawing.Size(124, 20);
            this.tbMatrixQ.TabIndex = 46;
            // 
            // tbMatrixM
            // 
            this.tbMatrixM.Location = new System.Drawing.Point(343, 454);
            this.tbMatrixM.Margin = new System.Windows.Forms.Padding(2);
            this.tbMatrixM.Name = "tbMatrixM";
            this.tbMatrixM.Size = new System.Drawing.Size(121, 20);
            this.tbMatrixM.TabIndex = 47;
            // 
            // lbBlockSz
            // 
            this.lbBlockSz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBlockSz.Location = new System.Drawing.Point(343, 382);
            this.lbBlockSz.Name = "lbBlockSz";
            this.lbBlockSz.Size = new System.Drawing.Size(121, 23);
            this.lbBlockSz.TabIndex = 48;
            this.lbBlockSz.Text = "Block Size:";
            this.lbBlockSz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMatrixRows
            // 
            this.lbMatrixRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMatrixRows.Location = new System.Drawing.Point(343, 429);
            this.lbMatrixRows.Name = "lbMatrixRows";
            this.lbMatrixRows.Size = new System.Drawing.Size(122, 23);
            this.lbMatrixRows.TabIndex = 49;
            this.lbMatrixRows.Text = "Matrix Rows:";
            this.lbMatrixRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFreqTest
            // 
            this.lbFreqTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFreqTest.Location = new System.Drawing.Point(338, 230);
            this.lbFreqTest.Name = "lbFreqTest";
            this.lbFreqTest.Size = new System.Drawing.Size(123, 19);
            this.lbFreqTest.TabIndex = 51;
            this.lbFreqTest.Text = "Frequency Test:";
            this.lbFreqTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbFreqTest
            // 
            this.tbFreqTest.Location = new System.Drawing.Point(338, 251);
            this.tbFreqTest.Margin = new System.Windows.Forms.Padding(2);
            this.tbFreqTest.Name = "tbFreqTest";
            this.tbFreqTest.ReadOnly = true;
            this.tbFreqTest.Size = new System.Drawing.Size(124, 20);
            this.tbFreqTest.TabIndex = 50;
            // 
            // tbLROTest
            // 
            this.tbLROTest.Location = new System.Drawing.Point(475, 251);
            this.tbLROTest.Margin = new System.Windows.Forms.Padding(2);
            this.tbLROTest.Name = "tbLROTest";
            this.tbLROTest.ReadOnly = true;
            this.tbLROTest.Size = new System.Drawing.Size(124, 20);
            this.tbLROTest.TabIndex = 52;
            // 
            // lbLROTest
            // 
            this.lbLROTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLROTest.Location = new System.Drawing.Point(474, 229);
            this.lbLROTest.Name = "lbLROTest";
            this.lbLROTest.Size = new System.Drawing.Size(124, 19);
            this.lbLROTest.TabIndex = 53;
            this.lbLROTest.Text = "Longest Run Of Ones Test:";
            this.lbLROTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRankTest
            // 
            this.lbRankTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRankTest.Location = new System.Drawing.Point(475, 273);
            this.lbRankTest.Name = "lbRankTest";
            this.lbRankTest.Size = new System.Drawing.Size(123, 15);
            this.lbRankTest.TabIndex = 57;
            this.lbRankTest.Text = "Rank Test:";
            this.lbRankTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRankTest
            // 
            this.tbRankTest.Location = new System.Drawing.Point(475, 293);
            this.tbRankTest.Margin = new System.Windows.Forms.Padding(2);
            this.tbRankTest.Name = "tbRankTest";
            this.tbRankTest.ReadOnly = true;
            this.tbRankTest.Size = new System.Drawing.Size(124, 20);
            this.tbRankTest.TabIndex = 56;
            // 
            // lbBlockFreqTest
            // 
            this.lbBlockFreqTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBlockFreqTest.Location = new System.Drawing.Point(339, 273);
            this.lbBlockFreqTest.Name = "lbBlockFreqTest";
            this.lbBlockFreqTest.Size = new System.Drawing.Size(123, 15);
            this.lbBlockFreqTest.TabIndex = 55;
            this.lbBlockFreqTest.Text = "Block Frequency Test:";
            this.lbBlockFreqTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBlockFreqTest
            // 
            this.tbBlockFreqTest.Location = new System.Drawing.Point(338, 293);
            this.tbBlockFreqTest.Margin = new System.Windows.Forms.Padding(2);
            this.tbBlockFreqTest.Name = "tbBlockFreqTest";
            this.tbBlockFreqTest.ReadOnly = true;
            this.tbBlockFreqTest.Size = new System.Drawing.Size(124, 20);
            this.tbBlockFreqTest.TabIndex = 54;
            // 
            // lbDFTTest
            // 
            this.lbDFTTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDFTTest.Location = new System.Drawing.Point(476, 315);
            this.lbDFTTest.Name = "lbDFTTest";
            this.lbDFTTest.Size = new System.Drawing.Size(123, 15);
            this.lbDFTTest.TabIndex = 61;
            this.lbDFTTest.Text = "DFT Test:";
            this.lbDFTTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDFTTest
            // 
            this.tbDFTTest.Location = new System.Drawing.Point(476, 333);
            this.tbDFTTest.Margin = new System.Windows.Forms.Padding(2);
            this.tbDFTTest.Name = "tbDFTTest";
            this.tbDFTTest.ReadOnly = true;
            this.tbDFTTest.Size = new System.Drawing.Size(124, 20);
            this.tbDFTTest.TabIndex = 60;
            // 
            // lbRunsTest
            // 
            this.lbRunsTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRunsTest.Location = new System.Drawing.Point(339, 315);
            this.lbRunsTest.Name = "lbRunsTest";
            this.lbRunsTest.Size = new System.Drawing.Size(123, 15);
            this.lbRunsTest.TabIndex = 59;
            this.lbRunsTest.Text = "Runs Test:";
            this.lbRunsTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRunsTest
            // 
            this.tbRunsTest.Location = new System.Drawing.Point(338, 333);
            this.tbRunsTest.Margin = new System.Windows.Forms.Padding(2);
            this.tbRunsTest.Name = "tbRunsTest";
            this.tbRunsTest.ReadOnly = true;
            this.tbRunsTest.Size = new System.Drawing.Size(124, 20);
            this.tbRunsTest.TabIndex = 58;
            // 
            // lbMatrixColumns
            // 
            this.lbMatrixColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMatrixColumns.Location = new System.Drawing.Point(476, 429);
            this.lbMatrixColumns.Name = "lbMatrixColumns";
            this.lbMatrixColumns.Size = new System.Drawing.Size(121, 23);
            this.lbMatrixColumns.TabIndex = 74;
            this.lbMatrixColumns.Text = "Matrix Columns:";
            this.lbMatrixColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbKeyA51
            // 
            this.tbKeyA51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKeyA51.Location = new System.Drawing.Point(12, 369);
            this.tbKeyA51.Multiline = true;
            this.tbKeyA51.Name = "tbKeyA51";
            this.tbKeyA51.ReadOnly = true;
            this.tbKeyA51.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbKeyA51.Size = new System.Drawing.Size(323, 105);
            this.tbKeyA51.TabIndex = 75;
            // 
            // tbKeyLength
            // 
            this.tbKeyLength.Location = new System.Drawing.Point(476, 407);
            this.tbKeyLength.Margin = new System.Windows.Forms.Padding(2);
            this.tbKeyLength.Name = "tbKeyLength";
            this.tbKeyLength.Size = new System.Drawing.Size(122, 20);
            this.tbKeyLength.TabIndex = 76;
            // 
            // lbKeyLength
            // 
            this.lbKeyLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbKeyLength.Location = new System.Drawing.Point(476, 382);
            this.lbKeyLength.Name = "lbKeyLength";
            this.lbKeyLength.Size = new System.Drawing.Size(122, 23);
            this.lbKeyLength.TabIndex = 77;
            this.lbKeyLength.Text = "Key Length:";
            this.lbKeyLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Encryptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(937, 528);
            this.Controls.Add(this.lbKeyLength);
            this.Controls.Add(this.tbKeyLength);
            this.Controls.Add(this.tbKeyA51);
            this.Controls.Add(this.lbMatrixColumns);
            this.Controls.Add(this.lbDFTTest);
            this.Controls.Add(this.tbDFTTest);
            this.Controls.Add(this.lbRunsTest);
            this.Controls.Add(this.tbRunsTest);
            this.Controls.Add(this.lbRankTest);
            this.Controls.Add(this.tbRankTest);
            this.Controls.Add(this.lbBlockFreqTest);
            this.Controls.Add(this.tbBlockFreqTest);
            this.Controls.Add(this.lbLROTest);
            this.Controls.Add(this.tbLROTest);
            this.Controls.Add(this.lbFreqTest);
            this.Controls.Add(this.tbFreqTest);
            this.Controls.Add(this.lbMatrixRows);
            this.Controls.Add(this.lbBlockSz);
            this.Controls.Add(this.tbMatrixM);
            this.Controls.Add(this.tbMatrixQ);
            this.Controls.Add(this.tbBlockSz);
            this.Controls.Add(this.butRunTests);
            this.Controls.Add(this.tbChartCiphertext);
            this.Controls.Add(this.tbChartInitText);
            this.Controls.Add(this.chSaveAsInitText);
            this.Controls.Add(this.chSaveInitText);
            this.Controls.Add(this.chSaveAsCiphertext);
            this.Controls.Add(this.chSaveCiphertext);
            this.Controls.Add(this.chCiphertext);
            this.Controls.Add(this.chInitText);
            this.Controls.Add(this.butResetInitText);
            this.Controls.Add(this.butResetCiphertext);
            this.Controls.Add(this.butNewInitText);
            this.Controls.Add(this.butNewCiphertext);
            this.Controls.Add(this.butSaveAsInitText);
            this.Controls.Add(this.butSaveAsCiphertext);
            this.Controls.Add(this.tbCiphertextFileName);
            this.Controls.Add(this.tbInitTextFileName);
            this.Controls.Add(this.butDecrypt);
            this.Controls.Add(this.butSaveCiphertext);
            this.Controls.Add(this.butOpenCiphertext);
            this.Controls.Add(this.butSaveInitText);
            this.Controls.Add(this.butOpenInitText);
            this.Controls.Add(this.tbCiphertext);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.cbInitialization);
            this.Controls.Add(this.lbCipherText);
            this.Controls.Add(this.lbInitText);
            this.Controls.Add(this.lbInitialization);
            this.Controls.Add(this.tbErrors);
            this.Controls.Add(this.lbErrors);
            this.Controls.Add(this.butEncrypt);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.tbInitText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Encryptor";
            ((System.ComponentModel.ISupportInitialize)(this.chInitText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCiphertext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbKeyLength;
        private System.Windows.Forms.Label lbKeyLength;

        private System.Windows.Forms.TextBox tbKeyA51;

        private System.Windows.Forms.Label lbMatrixColumns;

        private System.Windows.Forms.Label lbFreqTest;
        private System.Windows.Forms.TextBox tbFreqTest;
        private System.Windows.Forms.TextBox tbLROTest;
        private System.Windows.Forms.Label lbLROTest;
        private System.Windows.Forms.Label lbRankTest;
        private System.Windows.Forms.TextBox tbRankTest;
        private System.Windows.Forms.Label lbBlockFreqTest;
        private System.Windows.Forms.TextBox tbBlockFreqTest;
        private System.Windows.Forms.Label lbDFTTest;
        private System.Windows.Forms.TextBox tbDFTTest;
        private System.Windows.Forms.Label lbRunsTest;
        private System.Windows.Forms.TextBox tbRunsTest;

        private System.Windows.Forms.Label lbBlockSz;
        private System.Windows.Forms.Label lbMatrixRows;

        private System.Windows.Forms.TextBox tbBlockSz;
        private System.Windows.Forms.TextBox tbMatrixQ;
        private System.Windows.Forms.TextBox tbMatrixM;

        private System.Windows.Forms.Button butRunTests;

        private System.Windows.Forms.TextBox tbChartInitText;
        private System.Windows.Forms.TextBox tbChartCiphertext;

        private System.Windows.Forms.Button chSaveAsCiphertext;
        private System.Windows.Forms.Button chSaveCiphertext;
        private System.Windows.Forms.Button chSaveAsInitText;
        private System.Windows.Forms.Button chSaveInitText;

        private System.Windows.Forms.DataVisualization.Charting.Chart chInitText;

        private System.Windows.Forms.Button butResetCiphertext;
        private System.Windows.Forms.Button butResetInitText;

        private System.Windows.Forms.DataVisualization.Charting.Chart chCiphertext;

        private System.Windows.Forms.Button butNewCiphertext;
        private System.Windows.Forms.Button butNewInitText;

        private System.Windows.Forms.Button butSaveAsInitText;

        private System.Windows.Forms.Button butSaveAsCiphertext;

        private System.Windows.Forms.TextBox tbCiphertextFileName;

        private System.Windows.Forms.TextBox tbInitTextFileName;

        private System.Windows.Forms.Button butDecrypt;

        private System.Windows.Forms.Button butSaveCiphertext;
        private System.Windows.Forms.Button butOpenCiphertext;

        private System.Windows.Forms.Button butSaveInitText;

        private System.Windows.Forms.Button butOpenInitText;

        private System.Windows.Forms.TextBox tbKey;

        private System.Windows.Forms.ComboBox cbInitialization;

        private System.Windows.Forms.Label lbInitialization;
        private System.Windows.Forms.Label lbInitText;
        private System.Windows.Forms.Label lbCipherText;

        private System.Windows.Forms.Label lbErrors;
        private System.Windows.Forms.TextBox tbErrors;

        private System.Windows.Forms.Button butEncrypt;

        private System.Windows.Forms.Label lbKey;

        private System.Windows.Forms.TextBox tbInitText;

        private System.Windows.Forms.TextBox tbCiphertext;

        #endregion
    }
}