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
            this.lbCipFreqTest = new System.Windows.Forms.Label();
            this.tbCipFreqTest = new System.Windows.Forms.TextBox();
            this.tbCipLROTest = new System.Windows.Forms.TextBox();
            this.lbCipLROTest = new System.Windows.Forms.Label();
            this.lbCipRankTest = new System.Windows.Forms.Label();
            this.tbCipRankTest = new System.Windows.Forms.TextBox();
            this.lbCipBlockFreqTest = new System.Windows.Forms.Label();
            this.tbCipBlockFreqTest = new System.Windows.Forms.TextBox();
            this.lbCipDFTTest = new System.Windows.Forms.Label();
            this.tbCipDFTTest = new System.Windows.Forms.TextBox();
            this.lbCipRunsTest = new System.Windows.Forms.Label();
            this.tbCipRunsTest = new System.Windows.Forms.TextBox();
            this.lbInitDFTTest = new System.Windows.Forms.Label();
            this.tbInitDFTTest = new System.Windows.Forms.TextBox();
            this.lbInitRunsTest = new System.Windows.Forms.Label();
            this.tbInitRunsTest = new System.Windows.Forms.TextBox();
            this.lbInitRankTest = new System.Windows.Forms.Label();
            this.tbInitRankTest = new System.Windows.Forms.TextBox();
            this.lbInitBlockFreqTest = new System.Windows.Forms.Label();
            this.tbInitBlockFreqTest = new System.Windows.Forms.TextBox();
            this.lbInitLROTest = new System.Windows.Forms.Label();
            this.tbInitLROTest = new System.Windows.Forms.TextBox();
            this.lbInitFreqTest = new System.Windows.Forms.Label();
            this.tbInitFreqTest = new System.Windows.Forms.TextBox();
            this.lbMatrixColumns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chInitText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCiphertext)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInitText
            // 
            this.tbInitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInitText.Location = new System.Drawing.Point(16, 55);
            this.tbInitText.Margin = new System.Windows.Forms.Padding(4);
            this.tbInitText.Multiline = true;
            this.tbInitText.Name = "tbInitText";
            this.tbInitText.ReadOnly = true;
            this.tbInitText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInitText.Size = new System.Drawing.Size(429, 128);
            this.tbInitText.TabIndex = 1;
            // 
            // lbKey
            // 
            this.lbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbKey.Location = new System.Drawing.Point(174, 378);
            this.lbKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(271, 28);
            this.lbKey.TabIndex = 6;
            this.lbKey.Text = "Key (0...18446744073709551615):";
            this.lbKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butEncrypt
            // 
            this.butEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEncrypt.Location = new System.Drawing.Point(16, 451);
            this.butEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.butEncrypt.Name = "butEncrypt";
            this.butEncrypt.Size = new System.Drawing.Size(211, 36);
            this.butEncrypt.TabIndex = 7;
            this.butEncrypt.Text = "Encrypt";
            this.butEncrypt.UseVisualStyleBackColor = true;
            this.butEncrypt.Click += new System.EventHandler(this.butEncrypt_Click);
            // 
            // lbInitialization
            // 
            this.lbInitialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInitialization.Location = new System.Drawing.Point(16, 378);
            this.lbInitialization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInitialization.Name = "lbInitialization";
            this.lbInitialization.Size = new System.Drawing.Size(90, 28);
            this.lbInitialization.TabIndex = 10;
            this.lbInitialization.Text = "Initialization:";
            this.lbInitialization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbInitText
            // 
            this.lbInitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInitText.Location = new System.Drawing.Point(16, 11);
            this.lbInitText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInitText.Name = "lbInitText";
            this.lbInitText.Size = new System.Drawing.Size(400, 41);
            this.lbInitText.TabIndex = 11;
            this.lbInitText.Text = "Initial text:";
            this.lbInitText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCipherText
            // 
            this.lbCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCipherText.Location = new System.Drawing.Point(16, 188);
            this.lbCipherText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCipherText.Name = "lbCipherText";
            this.lbCipherText.Size = new System.Drawing.Size(400, 41);
            this.lbCipherText.TabIndex = 13;
            this.lbCipherText.Text = "Ciphertext:";
            this.lbCipherText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbInitialization
            // 
            this.cbInitialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInitialization.FormattingEnabled = true;
            this.cbInitialization.Items.AddRange(new object[] { "First Version", "Second Version" });
            this.cbInitialization.Location = new System.Drawing.Point(16, 410);
            this.cbInitialization.Margin = new System.Windows.Forms.Padding(4);
            this.cbInitialization.Name = "cbInitialization";
            this.cbInitialization.Size = new System.Drawing.Size(128, 24);
            this.cbInitialization.TabIndex = 14;
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey.Location = new System.Drawing.Point(174, 410);
            this.tbKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(271, 22);
            this.tbKey.TabIndex = 15;
            // 
            // tbCiphertext
            // 
            this.tbCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCiphertext.Location = new System.Drawing.Point(16, 233);
            this.tbCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.tbCiphertext.Multiline = true;
            this.tbCiphertext.Name = "tbCiphertext";
            this.tbCiphertext.ReadOnly = true;
            this.tbCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCiphertext.Size = new System.Drawing.Size(429, 128);
            this.tbCiphertext.TabIndex = 16;
            // 
            // butOpenInitText
            // 
            this.butOpenInitText.Image = ((System.Drawing.Image)(resources.GetObject("butOpenInitText.Image")));
            this.butOpenInitText.Location = new System.Drawing.Point(291, 21);
            this.butOpenInitText.Margin = new System.Windows.Forms.Padding(4);
            this.butOpenInitText.Name = "butOpenInitText";
            this.butOpenInitText.Size = new System.Drawing.Size(33, 31);
            this.butOpenInitText.TabIndex = 17;
            this.butOpenInitText.UseVisualStyleBackColor = true;
            this.butOpenInitText.Click += new System.EventHandler(this.butOpenInitText_Click);
            // 
            // butSaveInitText
            // 
            this.butSaveInitText.Image = ((System.Drawing.Image)(resources.GetObject("butSaveInitText.Image")));
            this.butSaveInitText.Location = new System.Drawing.Point(329, 21);
            this.butSaveInitText.Margin = new System.Windows.Forms.Padding(4);
            this.butSaveInitText.Name = "butSaveInitText";
            this.butSaveInitText.Size = new System.Drawing.Size(33, 31);
            this.butSaveInitText.TabIndex = 18;
            this.butSaveInitText.UseVisualStyleBackColor = true;
            this.butSaveInitText.Click += new System.EventHandler(this.butSaveInitText_Click);
            // 
            // butSaveCiphertext
            // 
            this.butSaveCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("butSaveCiphertext.Image")));
            this.butSaveCiphertext.Location = new System.Drawing.Point(332, 198);
            this.butSaveCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.butSaveCiphertext.Name = "butSaveCiphertext";
            this.butSaveCiphertext.Size = new System.Drawing.Size(33, 31);
            this.butSaveCiphertext.TabIndex = 20;
            this.butSaveCiphertext.UseVisualStyleBackColor = true;
            this.butSaveCiphertext.Click += new System.EventHandler(this.butSaveCiphertext_Click);
            // 
            // butOpenCiphertext
            // 
            this.butOpenCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("butOpenCiphertext.Image")));
            this.butOpenCiphertext.Location = new System.Drawing.Point(291, 198);
            this.butOpenCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.butOpenCiphertext.Name = "butOpenCiphertext";
            this.butOpenCiphertext.Size = new System.Drawing.Size(33, 31);
            this.butOpenCiphertext.TabIndex = 19;
            this.butOpenCiphertext.UseVisualStyleBackColor = true;
            this.butOpenCiphertext.Click += new System.EventHandler(this.butOpenCiphertext_Click);
            // 
            // butDecrypt
            // 
            this.butDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDecrypt.Location = new System.Drawing.Point(234, 451);
            this.butDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.butDecrypt.Name = "butDecrypt";
            this.butDecrypt.Size = new System.Drawing.Size(211, 36);
            this.butDecrypt.TabIndex = 21;
            this.butDecrypt.Text = "Decrypt";
            this.butDecrypt.UseVisualStyleBackColor = true;
            this.butDecrypt.Click += new System.EventHandler(this.butDecrypt_Click);
            // 
            // tbInitTextFileName
            // 
            this.tbInitTextFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInitTextFileName.Location = new System.Drawing.Point(106, 17);
            this.tbInitTextFileName.Margin = new System.Windows.Forms.Padding(4);
            this.tbInitTextFileName.Name = "tbInitTextFileName";
            this.tbInitTextFileName.ReadOnly = true;
            this.tbInitTextFileName.Size = new System.Drawing.Size(136, 22);
            this.tbInitTextFileName.TabIndex = 24;
            // 
            // tbCiphertextFileName
            // 
            this.tbCiphertextFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCiphertextFileName.Location = new System.Drawing.Point(106, 194);
            this.tbCiphertextFileName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCiphertextFileName.Name = "tbCiphertextFileName";
            this.tbCiphertextFileName.ReadOnly = true;
            this.tbCiphertextFileName.Size = new System.Drawing.Size(136, 22);
            this.tbCiphertextFileName.TabIndex = 25;
            // 
            // lbErrors
            // 
            this.lbErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbErrors.Location = new System.Drawing.Point(807, 378);
            this.lbErrors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(60, 28);
            this.lbErrors.TabIndex = 8;
            this.lbErrors.Text = "Errors:";
            this.lbErrors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbErrors
            // 
            this.tbErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbErrors.Location = new System.Drawing.Point(806, 412);
            this.tbErrors.Margin = new System.Windows.Forms.Padding(4);
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.ReadOnly = true;
            this.tbErrors.Size = new System.Drawing.Size(430, 22);
            this.tbErrors.TabIndex = 9;
            // 
            // butSaveAsCiphertext
            // 
            this.butSaveAsCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("butSaveAsCiphertext.Image")));
            this.butSaveAsCiphertext.Location = new System.Drawing.Point(373, 198);
            this.butSaveAsCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.butSaveAsCiphertext.Name = "butSaveAsCiphertext";
            this.butSaveAsCiphertext.Size = new System.Drawing.Size(33, 31);
            this.butSaveAsCiphertext.TabIndex = 26;
            this.butSaveAsCiphertext.UseVisualStyleBackColor = true;
            this.butSaveAsCiphertext.Click += new System.EventHandler(this.butSaveAsCiphertext_Click);
            // 
            // butSaveAsInitText
            // 
            this.butSaveAsInitText.Image = ((System.Drawing.Image)(resources.GetObject("butSaveAsInitText.Image")));
            this.butSaveAsInitText.Location = new System.Drawing.Point(371, 21);
            this.butSaveAsInitText.Margin = new System.Windows.Forms.Padding(4);
            this.butSaveAsInitText.Name = "butSaveAsInitText";
            this.butSaveAsInitText.Size = new System.Drawing.Size(33, 31);
            this.butSaveAsInitText.TabIndex = 27;
            this.butSaveAsInitText.UseVisualStyleBackColor = true;
            this.butSaveAsInitText.Click += new System.EventHandler(this.butSaveAsInitText_Click);
            // 
            // butNewCiphertext
            // 
            this.butNewCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("butNewCiphertext.Image")));
            this.butNewCiphertext.Location = new System.Drawing.Point(250, 198);
            this.butNewCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.butNewCiphertext.Name = "butNewCiphertext";
            this.butNewCiphertext.Size = new System.Drawing.Size(33, 31);
            this.butNewCiphertext.TabIndex = 28;
            this.butNewCiphertext.UseVisualStyleBackColor = true;
            this.butNewCiphertext.Click += new System.EventHandler(this.butNewCiphertext_Click);
            // 
            // butNewInitText
            // 
            this.butNewInitText.Image = ((System.Drawing.Image)(resources.GetObject("butNewInitText.Image")));
            this.butNewInitText.Location = new System.Drawing.Point(250, 21);
            this.butNewInitText.Margin = new System.Windows.Forms.Padding(4);
            this.butNewInitText.Name = "butNewInitText";
            this.butNewInitText.Size = new System.Drawing.Size(33, 31);
            this.butNewInitText.TabIndex = 29;
            this.butNewInitText.UseVisualStyleBackColor = true;
            this.butNewInitText.Click += new System.EventHandler(this.butNewInitText_Click);
            // 
            // butResetCiphertext
            // 
            this.butResetCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("butResetCiphertext.Image")));
            this.butResetCiphertext.Location = new System.Drawing.Point(412, 198);
            this.butResetCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.butResetCiphertext.Name = "butResetCiphertext";
            this.butResetCiphertext.Size = new System.Drawing.Size(33, 31);
            this.butResetCiphertext.TabIndex = 34;
            this.butResetCiphertext.UseVisualStyleBackColor = true;
            this.butResetCiphertext.Click += new System.EventHandler(this.butResetCiphertext_Click);
            // 
            // butResetInitText
            // 
            this.butResetInitText.Image = ((System.Drawing.Image)(resources.GetObject("butResetInitText.Image")));
            this.butResetInitText.Location = new System.Drawing.Point(412, 21);
            this.butResetInitText.Margin = new System.Windows.Forms.Padding(4);
            this.butResetInitText.Name = "butResetInitText";
            this.butResetInitText.Size = new System.Drawing.Size(33, 31);
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
            this.chInitText.Location = new System.Drawing.Point(807, 55);
            this.chInitText.Name = "chInitText";
            this.chInitText.Size = new System.Drawing.Size(429, 128);
            this.chInitText.TabIndex = 36;
            // 
            // chCiphertext
            // 
            chartArea2.Name = "ChartArea1";
            this.chCiphertext.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chCiphertext.Legends.Add(legend2);
            this.chCiphertext.Location = new System.Drawing.Point(807, 233);
            this.chCiphertext.Name = "chCiphertext";
            this.chCiphertext.Size = new System.Drawing.Size(429, 128);
            this.chCiphertext.TabIndex = 37;
            // 
            // chSaveAsCiphertext
            // 
            this.chSaveAsCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("chSaveAsCiphertext.Image")));
            this.chSaveAsCiphertext.Location = new System.Drawing.Point(1203, 198);
            this.chSaveAsCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.chSaveAsCiphertext.Name = "chSaveAsCiphertext";
            this.chSaveAsCiphertext.Size = new System.Drawing.Size(33, 31);
            this.chSaveAsCiphertext.TabIndex = 39;
            this.chSaveAsCiphertext.UseVisualStyleBackColor = true;
            this.chSaveAsCiphertext.Click += new System.EventHandler(this.chSaveAsCiphertext_Click);
            // 
            // chSaveCiphertext
            // 
            this.chSaveCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("chSaveCiphertext.Image")));
            this.chSaveCiphertext.Location = new System.Drawing.Point(1162, 198);
            this.chSaveCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.chSaveCiphertext.Name = "chSaveCiphertext";
            this.chSaveCiphertext.Size = new System.Drawing.Size(33, 31);
            this.chSaveCiphertext.TabIndex = 38;
            this.chSaveCiphertext.UseVisualStyleBackColor = true;
            this.chSaveCiphertext.Click += new System.EventHandler(this.chSaveCiphertext_Click);
            // 
            // chSaveAsInitText
            // 
            this.chSaveAsInitText.Image = ((System.Drawing.Image)(resources.GetObject("chSaveAsInitText.Image")));
            this.chSaveAsInitText.Location = new System.Drawing.Point(1203, 21);
            this.chSaveAsInitText.Margin = new System.Windows.Forms.Padding(4);
            this.chSaveAsInitText.Name = "chSaveAsInitText";
            this.chSaveAsInitText.Size = new System.Drawing.Size(33, 31);
            this.chSaveAsInitText.TabIndex = 41;
            this.chSaveAsInitText.UseVisualStyleBackColor = true;
            this.chSaveAsInitText.Click += new System.EventHandler(this.chSaveAsInitText_Click);
            // 
            // chSaveInitText
            // 
            this.chSaveInitText.Image = ((System.Drawing.Image)(resources.GetObject("chSaveInitText.Image")));
            this.chSaveInitText.Location = new System.Drawing.Point(1162, 21);
            this.chSaveInitText.Margin = new System.Windows.Forms.Padding(4);
            this.chSaveInitText.Name = "chSaveInitText";
            this.chSaveInitText.Size = new System.Drawing.Size(33, 31);
            this.chSaveInitText.TabIndex = 40;
            this.chSaveInitText.UseVisualStyleBackColor = true;
            this.chSaveInitText.Click += new System.EventHandler(this.chSaveInitText_Click);
            // 
            // tbChartInitText
            // 
            this.tbChartInitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChartInitText.Location = new System.Drawing.Point(1018, 25);
            this.tbChartInitText.Margin = new System.Windows.Forms.Padding(4);
            this.tbChartInitText.Name = "tbChartInitText";
            this.tbChartInitText.ReadOnly = true;
            this.tbChartInitText.Size = new System.Drawing.Size(136, 22);
            this.tbChartInitText.TabIndex = 42;
            // 
            // tbChartCiphertext
            // 
            this.tbChartCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChartCiphertext.Location = new System.Drawing.Point(1018, 202);
            this.tbChartCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.tbChartCiphertext.Name = "tbChartCiphertext";
            this.tbChartCiphertext.ReadOnly = true;
            this.tbChartCiphertext.Size = new System.Drawing.Size(136, 22);
            this.tbChartCiphertext.TabIndex = 43;
            // 
            // butRunTests
            // 
            this.butRunTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butRunTests.Location = new System.Drawing.Point(453, 451);
            this.butRunTests.Margin = new System.Windows.Forms.Padding(4);
            this.butRunTests.Name = "butRunTests";
            this.butRunTests.Size = new System.Drawing.Size(346, 36);
            this.butRunTests.TabIndex = 44;
            this.butRunTests.Text = "Run Tests";
            this.butRunTests.UseVisualStyleBackColor = true;
            this.butRunTests.Click += new System.EventHandler(this.butRunTests_Click);
            // 
            // tbBlockSz
            // 
            this.tbBlockSz.Location = new System.Drawing.Point(453, 412);
            this.tbBlockSz.Name = "tbBlockSz";
            this.tbBlockSz.Size = new System.Drawing.Size(108, 22);
            this.tbBlockSz.TabIndex = 45;
            // 
            // tbMatrixQ
            // 
            this.tbMatrixQ.Location = new System.Drawing.Point(688, 412);
            this.tbMatrixQ.Name = "tbMatrixQ";
            this.tbMatrixQ.Size = new System.Drawing.Size(111, 22);
            this.tbMatrixQ.TabIndex = 46;
            // 
            // tbMatrixM
            // 
            this.tbMatrixM.Location = new System.Drawing.Point(572, 412);
            this.tbMatrixM.Name = "tbMatrixM";
            this.tbMatrixM.Size = new System.Drawing.Size(111, 22);
            this.tbMatrixM.TabIndex = 47;
            // 
            // lbBlockSz
            // 
            this.lbBlockSz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBlockSz.Location = new System.Drawing.Point(453, 378);
            this.lbBlockSz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBlockSz.Name = "lbBlockSz";
            this.lbBlockSz.Size = new System.Drawing.Size(74, 28);
            this.lbBlockSz.TabIndex = 48;
            this.lbBlockSz.Text = "Block Size:";
            this.lbBlockSz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMatrixRows
            // 
            this.lbMatrixRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMatrixRows.Location = new System.Drawing.Point(572, 378);
            this.lbMatrixRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatrixRows.Name = "lbMatrixRows";
            this.lbMatrixRows.Size = new System.Drawing.Size(111, 28);
            this.lbMatrixRows.TabIndex = 49;
            this.lbMatrixRows.Text = "Matrix Rows:";
            this.lbMatrixRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCipFreqTest
            // 
            this.lbCipFreqTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCipFreqTest.Location = new System.Drawing.Point(453, 201);
            this.lbCipFreqTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCipFreqTest.Name = "lbCipFreqTest";
            this.lbCipFreqTest.Size = new System.Drawing.Size(164, 19);
            this.lbCipFreqTest.TabIndex = 51;
            this.lbCipFreqTest.Text = "Frequency Test:";
            this.lbCipFreqTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCipFreqTest
            // 
            this.tbCipFreqTest.Location = new System.Drawing.Point(453, 224);
            this.tbCipFreqTest.Name = "tbCipFreqTest";
            this.tbCipFreqTest.ReadOnly = true;
            this.tbCipFreqTest.Size = new System.Drawing.Size(164, 22);
            this.tbCipFreqTest.TabIndex = 50;
            // 
            // tbCipLROTest
            // 
            this.tbCipLROTest.Location = new System.Drawing.Point(635, 224);
            this.tbCipLROTest.Name = "tbCipLROTest";
            this.tbCipLROTest.ReadOnly = true;
            this.tbCipLROTest.Size = new System.Drawing.Size(164, 22);
            this.tbCipLROTest.TabIndex = 52;
            // 
            // lbCipLROTest
            // 
            this.lbCipLROTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCipLROTest.Location = new System.Drawing.Point(635, 201);
            this.lbCipLROTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCipLROTest.Name = "lbCipLROTest";
            this.lbCipLROTest.Size = new System.Drawing.Size(171, 19);
            this.lbCipLROTest.TabIndex = 53;
            this.lbCipLROTest.Text = "Longest Run Of Ones Test:";
            this.lbCipLROTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCipRankTest
            // 
            this.lbCipRankTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCipRankTest.Location = new System.Drawing.Point(635, 260);
            this.lbCipRankTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCipRankTest.Name = "lbCipRankTest";
            this.lbCipRankTest.Size = new System.Drawing.Size(164, 19);
            this.lbCipRankTest.TabIndex = 57;
            this.lbCipRankTest.Text = "Rank Test:";
            this.lbCipRankTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCipRankTest
            // 
            this.tbCipRankTest.Location = new System.Drawing.Point(635, 283);
            this.tbCipRankTest.Name = "tbCipRankTest";
            this.tbCipRankTest.ReadOnly = true;
            this.tbCipRankTest.Size = new System.Drawing.Size(164, 22);
            this.tbCipRankTest.TabIndex = 56;
            // 
            // lbCipBlockFreqTest
            // 
            this.lbCipBlockFreqTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCipBlockFreqTest.Location = new System.Drawing.Point(453, 260);
            this.lbCipBlockFreqTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCipBlockFreqTest.Name = "lbCipBlockFreqTest";
            this.lbCipBlockFreqTest.Size = new System.Drawing.Size(164, 19);
            this.lbCipBlockFreqTest.TabIndex = 55;
            this.lbCipBlockFreqTest.Text = "Block Frequency Test:";
            this.lbCipBlockFreqTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCipBlockFreqTest
            // 
            this.tbCipBlockFreqTest.Location = new System.Drawing.Point(453, 283);
            this.tbCipBlockFreqTest.Name = "tbCipBlockFreqTest";
            this.tbCipBlockFreqTest.ReadOnly = true;
            this.tbCipBlockFreqTest.Size = new System.Drawing.Size(164, 22);
            this.tbCipBlockFreqTest.TabIndex = 54;
            // 
            // lbCipDFTTest
            // 
            this.lbCipDFTTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCipDFTTest.Location = new System.Drawing.Point(635, 316);
            this.lbCipDFTTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCipDFTTest.Name = "lbCipDFTTest";
            this.lbCipDFTTest.Size = new System.Drawing.Size(164, 19);
            this.lbCipDFTTest.TabIndex = 61;
            this.lbCipDFTTest.Text = "DFT Test:";
            this.lbCipDFTTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCipDFTTest
            // 
            this.tbCipDFTTest.Location = new System.Drawing.Point(635, 339);
            this.tbCipDFTTest.Name = "tbCipDFTTest";
            this.tbCipDFTTest.ReadOnly = true;
            this.tbCipDFTTest.Size = new System.Drawing.Size(164, 22);
            this.tbCipDFTTest.TabIndex = 60;
            // 
            // lbCipRunsTest
            // 
            this.lbCipRunsTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCipRunsTest.Location = new System.Drawing.Point(453, 316);
            this.lbCipRunsTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCipRunsTest.Name = "lbCipRunsTest";
            this.lbCipRunsTest.Size = new System.Drawing.Size(164, 19);
            this.lbCipRunsTest.TabIndex = 59;
            this.lbCipRunsTest.Text = "Runs Test:";
            this.lbCipRunsTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCipRunsTest
            // 
            this.tbCipRunsTest.Location = new System.Drawing.Point(453, 339);
            this.tbCipRunsTest.Name = "tbCipRunsTest";
            this.tbCipRunsTest.ReadOnly = true;
            this.tbCipRunsTest.Size = new System.Drawing.Size(164, 22);
            this.tbCipRunsTest.TabIndex = 58;
            // 
            // lbInitDFTTest
            // 
            this.lbInitDFTTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInitDFTTest.Location = new System.Drawing.Point(635, 138);
            this.lbInitDFTTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInitDFTTest.Name = "lbInitDFTTest";
            this.lbInitDFTTest.Size = new System.Drawing.Size(164, 19);
            this.lbInitDFTTest.TabIndex = 73;
            this.lbInitDFTTest.Text = "DFT Test:";
            this.lbInitDFTTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInitDFTTest
            // 
            this.tbInitDFTTest.Location = new System.Drawing.Point(635, 161);
            this.tbInitDFTTest.Name = "tbInitDFTTest";
            this.tbInitDFTTest.ReadOnly = true;
            this.tbInitDFTTest.Size = new System.Drawing.Size(164, 22);
            this.tbInitDFTTest.TabIndex = 72;
            // 
            // lbInitRunsTest
            // 
            this.lbInitRunsTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInitRunsTest.Location = new System.Drawing.Point(453, 138);
            this.lbInitRunsTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInitRunsTest.Name = "lbInitRunsTest";
            this.lbInitRunsTest.Size = new System.Drawing.Size(164, 19);
            this.lbInitRunsTest.TabIndex = 71;
            this.lbInitRunsTest.Text = "Runs Test:";
            this.lbInitRunsTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInitRunsTest
            // 
            this.tbInitRunsTest.Location = new System.Drawing.Point(453, 161);
            this.tbInitRunsTest.Name = "tbInitRunsTest";
            this.tbInitRunsTest.ReadOnly = true;
            this.tbInitRunsTest.Size = new System.Drawing.Size(164, 22);
            this.tbInitRunsTest.TabIndex = 70;
            // 
            // lbInitRankTest
            // 
            this.lbInitRankTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInitRankTest.Location = new System.Drawing.Point(635, 82);
            this.lbInitRankTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInitRankTest.Name = "lbInitRankTest";
            this.lbInitRankTest.Size = new System.Drawing.Size(164, 19);
            this.lbInitRankTest.TabIndex = 69;
            this.lbInitRankTest.Text = "Rank Test:";
            this.lbInitRankTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInitRankTest
            // 
            this.tbInitRankTest.Location = new System.Drawing.Point(635, 105);
            this.tbInitRankTest.Name = "tbInitRankTest";
            this.tbInitRankTest.ReadOnly = true;
            this.tbInitRankTest.Size = new System.Drawing.Size(164, 22);
            this.tbInitRankTest.TabIndex = 68;
            // 
            // lbInitBlockFreqTest
            // 
            this.lbInitBlockFreqTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInitBlockFreqTest.Location = new System.Drawing.Point(453, 82);
            this.lbInitBlockFreqTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInitBlockFreqTest.Name = "lbInitBlockFreqTest";
            this.lbInitBlockFreqTest.Size = new System.Drawing.Size(164, 19);
            this.lbInitBlockFreqTest.TabIndex = 67;
            this.lbInitBlockFreqTest.Text = "Block Frequency Test:";
            this.lbInitBlockFreqTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInitBlockFreqTest
            // 
            this.tbInitBlockFreqTest.Location = new System.Drawing.Point(453, 105);
            this.tbInitBlockFreqTest.Name = "tbInitBlockFreqTest";
            this.tbInitBlockFreqTest.ReadOnly = true;
            this.tbInitBlockFreqTest.Size = new System.Drawing.Size(164, 22);
            this.tbInitBlockFreqTest.TabIndex = 66;
            // 
            // lbInitLROTest
            // 
            this.lbInitLROTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInitLROTest.Location = new System.Drawing.Point(635, 23);
            this.lbInitLROTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInitLROTest.Name = "lbInitLROTest";
            this.lbInitLROTest.Size = new System.Drawing.Size(171, 19);
            this.lbInitLROTest.TabIndex = 65;
            this.lbInitLROTest.Text = "Longest Run Of Ones Test:";
            this.lbInitLROTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInitLROTest
            // 
            this.tbInitLROTest.Location = new System.Drawing.Point(635, 46);
            this.tbInitLROTest.Name = "tbInitLROTest";
            this.tbInitLROTest.ReadOnly = true;
            this.tbInitLROTest.Size = new System.Drawing.Size(164, 22);
            this.tbInitLROTest.TabIndex = 64;
            // 
            // lbInitFreqTest
            // 
            this.lbInitFreqTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInitFreqTest.Location = new System.Drawing.Point(453, 23);
            this.lbInitFreqTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInitFreqTest.Name = "lbInitFreqTest";
            this.lbInitFreqTest.Size = new System.Drawing.Size(164, 19);
            this.lbInitFreqTest.TabIndex = 63;
            this.lbInitFreqTest.Text = "Frequency Test:";
            this.lbInitFreqTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInitFreqTest
            // 
            this.tbInitFreqTest.Location = new System.Drawing.Point(453, 46);
            this.tbInitFreqTest.Name = "tbInitFreqTest";
            this.tbInitFreqTest.ReadOnly = true;
            this.tbInitFreqTest.Size = new System.Drawing.Size(164, 22);
            this.tbInitFreqTest.TabIndex = 62;
            // 
            // lbMatrixColumns
            // 
            this.lbMatrixColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMatrixColumns.Location = new System.Drawing.Point(688, 378);
            this.lbMatrixColumns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatrixColumns.Name = "lbMatrixColumns";
            this.lbMatrixColumns.Size = new System.Drawing.Size(111, 28);
            this.lbMatrixColumns.TabIndex = 74;
            this.lbMatrixColumns.Text = "Matrix Columns:";
            this.lbMatrixColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Encryptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1249, 500);
            this.Controls.Add(this.lbMatrixColumns);
            this.Controls.Add(this.lbInitDFTTest);
            this.Controls.Add(this.tbInitDFTTest);
            this.Controls.Add(this.lbInitRunsTest);
            this.Controls.Add(this.tbInitRunsTest);
            this.Controls.Add(this.lbInitRankTest);
            this.Controls.Add(this.tbInitRankTest);
            this.Controls.Add(this.lbInitBlockFreqTest);
            this.Controls.Add(this.tbInitBlockFreqTest);
            this.Controls.Add(this.lbInitLROTest);
            this.Controls.Add(this.tbInitLROTest);
            this.Controls.Add(this.lbInitFreqTest);
            this.Controls.Add(this.tbInitFreqTest);
            this.Controls.Add(this.lbCipDFTTest);
            this.Controls.Add(this.tbCipDFTTest);
            this.Controls.Add(this.lbCipRunsTest);
            this.Controls.Add(this.tbCipRunsTest);
            this.Controls.Add(this.lbCipRankTest);
            this.Controls.Add(this.tbCipRankTest);
            this.Controls.Add(this.lbCipBlockFreqTest);
            this.Controls.Add(this.tbCipBlockFreqTest);
            this.Controls.Add(this.lbCipLROTest);
            this.Controls.Add(this.tbCipLROTest);
            this.Controls.Add(this.lbCipFreqTest);
            this.Controls.Add(this.tbCipFreqTest);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Encryptor";
            ((System.ComponentModel.ISupportInitialize)(this.chInitText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCiphertext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbMatrixColumns;

        private System.Windows.Forms.Label lbInitDFTTest;
        private System.Windows.Forms.TextBox tbInitDFTTest;
        private System.Windows.Forms.Label lbInitRunsTest;
        private System.Windows.Forms.TextBox tbInitRunsTest;
        private System.Windows.Forms.Label lbInitRankTest;
        private System.Windows.Forms.TextBox tbInitRankTest;
        private System.Windows.Forms.Label lbInitBlockFreqTest;
        private System.Windows.Forms.TextBox tbInitBlockFreqTest;
        private System.Windows.Forms.Label lbInitLROTest;
        private System.Windows.Forms.TextBox tbInitLROTest;
        private System.Windows.Forms.Label lbInitFreqTest;
        private System.Windows.Forms.TextBox tbInitFreqTest;

        private System.Windows.Forms.Label lbCipFreqTest;
        private System.Windows.Forms.TextBox tbCipFreqTest;
        private System.Windows.Forms.TextBox tbCipLROTest;
        private System.Windows.Forms.Label lbCipLROTest;
        private System.Windows.Forms.Label lbCipRankTest;
        private System.Windows.Forms.TextBox tbCipRankTest;
        private System.Windows.Forms.Label lbCipBlockFreqTest;
        private System.Windows.Forms.TextBox tbCipBlockFreqTest;
        private System.Windows.Forms.Label lbCipDFTTest;
        private System.Windows.Forms.TextBox tbCipDFTTest;
        private System.Windows.Forms.Label lbCipRunsTest;
        private System.Windows.Forms.TextBox tbCipRunsTest;

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