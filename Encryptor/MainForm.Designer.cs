namespace Encryptor
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.tbKeyA51 = new System.Windows.Forms.TextBox();
            this.lbGeneratedKey = new System.Windows.Forms.Label();
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
            this.lbKey.Location = new System.Drawing.Point(191, 383);
            this.lbKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(244, 28);
            this.lbKey.TabIndex = 6;
            this.lbKey.Text = "Key (0...18446744073709551615):";
            this.lbKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butEncrypt
            // 
            this.butEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEncrypt.Location = new System.Drawing.Point(16, 602);
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
            this.lbInitialization.Size = new System.Drawing.Size(91, 28);
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
            this.cbInitialization.Items.AddRange(new object[] { "Default Version", "Improved Version" });
            this.cbInitialization.Location = new System.Drawing.Point(16, 410);
            this.cbInitialization.Margin = new System.Windows.Forms.Padding(4);
            this.cbInitialization.Name = "cbInitialization";
            this.cbInitialization.Size = new System.Drawing.Size(156, 24);
            this.cbInitialization.TabIndex = 14;
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey.Location = new System.Drawing.Point(191, 410);
            this.tbKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(253, 22);
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
            this.butDecrypt.Location = new System.Drawing.Point(235, 602);
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
            this.tbInitTextFileName.Location = new System.Drawing.Point(107, 17);
            this.tbInitTextFileName.Margin = new System.Windows.Forms.Padding(4);
            this.tbInitTextFileName.Name = "tbInitTextFileName";
            this.tbInitTextFileName.ReadOnly = true;
            this.tbInitTextFileName.Size = new System.Drawing.Size(136, 22);
            this.tbInitTextFileName.TabIndex = 24;
            // 
            // tbCiphertextFileName
            // 
            this.tbCiphertextFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCiphertextFileName.Location = new System.Drawing.Point(107, 194);
            this.tbCiphertextFileName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCiphertextFileName.Name = "tbCiphertextFileName";
            this.tbCiphertextFileName.ReadOnly = true;
            this.tbCiphertextFileName.Size = new System.Drawing.Size(136, 22);
            this.tbCiphertextFileName.TabIndex = 25;
            // 
            // lbErrors
            // 
            this.lbErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbErrors.Location = new System.Drawing.Point(461, 388);
            this.lbErrors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(60, 21);
            this.lbErrors.TabIndex = 8;
            this.lbErrors.Text = "Errors:";
            this.lbErrors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbErrors
            // 
            this.tbErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbErrors.Location = new System.Drawing.Point(461, 412);
            this.tbErrors.Margin = new System.Windows.Forms.Padding(4);
            this.tbErrors.Multiline = true;
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.ReadOnly = true;
            this.tbErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbErrors.Size = new System.Drawing.Size(429, 222);
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
            this.butNewCiphertext.Location = new System.Drawing.Point(251, 198);
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
            this.butNewInitText.Location = new System.Drawing.Point(251, 21);
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
            this.chInitText.Location = new System.Drawing.Point(461, 55);
            this.chInitText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.chCiphertext.Location = new System.Drawing.Point(461, 233);
            this.chCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chCiphertext.Name = "chCiphertext";
            this.chCiphertext.Size = new System.Drawing.Size(429, 128);
            this.chCiphertext.TabIndex = 37;
            // 
            // chSaveAsCiphertext
            // 
            this.chSaveAsCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("chSaveAsCiphertext.Image")));
            this.chSaveAsCiphertext.Location = new System.Drawing.Point(857, 198);
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
            this.chSaveCiphertext.Location = new System.Drawing.Point(817, 198);
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
            this.chSaveAsInitText.Location = new System.Drawing.Point(857, 21);
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
            this.chSaveInitText.Location = new System.Drawing.Point(817, 21);
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
            this.tbChartInitText.Location = new System.Drawing.Point(673, 25);
            this.tbChartInitText.Margin = new System.Windows.Forms.Padding(4);
            this.tbChartInitText.Name = "tbChartInitText";
            this.tbChartInitText.ReadOnly = true;
            this.tbChartInitText.Size = new System.Drawing.Size(136, 22);
            this.tbChartInitText.TabIndex = 42;
            // 
            // tbChartCiphertext
            // 
            this.tbChartCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChartCiphertext.Location = new System.Drawing.Point(673, 202);
            this.tbChartCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.tbChartCiphertext.Name = "tbChartCiphertext";
            this.tbChartCiphertext.ReadOnly = true;
            this.tbChartCiphertext.Size = new System.Drawing.Size(136, 22);
            this.tbChartCiphertext.TabIndex = 43;
            // 
            // tbKeyA51
            // 
            this.tbKeyA51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKeyA51.Location = new System.Drawing.Point(16, 472);
            this.tbKeyA51.Margin = new System.Windows.Forms.Padding(4);
            this.tbKeyA51.Multiline = true;
            this.tbKeyA51.Name = "tbKeyA51";
            this.tbKeyA51.ReadOnly = true;
            this.tbKeyA51.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbKeyA51.Size = new System.Drawing.Size(429, 110);
            this.tbKeyA51.TabIndex = 75;
            // 
            // lbGeneratedKey
            // 
            this.lbGeneratedKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGeneratedKey.Location = new System.Drawing.Point(16, 447);
            this.lbGeneratedKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGeneratedKey.Name = "lbGeneratedKey";
            this.lbGeneratedKey.Size = new System.Drawing.Size(172, 21);
            this.lbGeneratedKey.TabIndex = 76;
            this.lbGeneratedKey.Text = "Generated key:";
            this.lbGeneratedKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(910, 650);
            this.Controls.Add(this.lbGeneratedKey);
            this.Controls.Add(this.tbKeyA51);
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
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.chInitText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCiphertext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbGeneratedKey;

        private System.Windows.Forms.TextBox tbKeyA51;

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
