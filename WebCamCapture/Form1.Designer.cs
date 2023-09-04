namespace WebCamCapture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxWebCamList = new ComboBox();
            btnStart = new Button();
            btnCapture = new Button();
            btnSaveImage = new Button();
            btnExit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebCamList
            // 
            comboBoxWebCamList.FormattingEnabled = true;
            comboBoxWebCamList.Location = new Point(31, 14);
            comboBoxWebCamList.Name = "comboBoxWebCamList";
            comboBoxWebCamList.Size = new Size(182, 33);
            comboBoxWebCamList.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(248, 14);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(121, 34);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(386, 14);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(121, 34);
            btnCapture.TabIndex = 2;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new Point(528, 14);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(121, 34);
            btnSaveImage.TabIndex = 3;
            btnSaveImage.Text = "Save Image";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1076, 14);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(31, 86);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1130, 513);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(568, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(559, 507);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 636);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnExit);
            Controls.Add(btnSaveImage);
            Controls.Add(btnCapture);
            Controls.Add(btnStart);
            Controls.Add(comboBoxWebCamList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxWebCamList;
        private Button btnStart;
        private Button btnCapture;
        private Button btnSaveImage;
        private Button btnExit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}