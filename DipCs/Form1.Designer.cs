namespace DipCs
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLoadImage = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnSaveImage = new Button();
            btnBasicCopy = new Button();
            btnGrayScale = new Button();
            btnInvert = new Button();
            btnHistogram = new Button();
            btnSepia = new Button();
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(50, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(486, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 400);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(59, 585);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(115, 48);
            btnLoadImage.TabIndex = 1;
            btnLoadImage.Text = "Load Image";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new Point(180, 585);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(115, 48);
            btnSaveImage.TabIndex = 2;
            btnSaveImage.Text = "Save Image";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // btnBasicCopy
            // 
            btnBasicCopy.Location = new Point(487, 585);
            btnBasicCopy.Name = "btnBasicCopy";
            btnBasicCopy.Size = new Size(115, 48);
            btnBasicCopy.TabIndex = 3;
            btnBasicCopy.Text = "Basic Copy";
            btnBasicCopy.UseVisualStyleBackColor = true;
            btnBasicCopy.Click += btnBasicCopy_Click;
            // 
            // btnGrayScale
            // 
            btnGrayScale.Location = new Point(608, 585);
            btnGrayScale.Name = "btnGrayScale";
            btnGrayScale.Size = new Size(115, 48);
            btnGrayScale.TabIndex = 4;
            btnGrayScale.Text = "Grayscale";
            btnGrayScale.UseVisualStyleBackColor = true;
            btnGrayScale.Click += btnGrayScale_Click;
            // 
            // btnInvert
            // 
            btnInvert.Location = new Point(729, 585);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(115, 48);
            btnInvert.TabIndex = 5;
            btnInvert.Text = "Invert";
            btnInvert.UseVisualStyleBackColor = true;
            btnInvert.Click += btnInvert_Click;
            // 
            // btnHistogram
            // 
            btnHistogram.Location = new Point(487, 639);
            btnHistogram.Name = "btnHistogram";
            btnHistogram.Size = new Size(115, 48);
            btnHistogram.TabIndex = 6;
            btnHistogram.Text = "Histogram";
            btnHistogram.UseVisualStyleBackColor = true;
            btnHistogram.Click += btnHistogram_Click;
            // 
            // btnSepia
            // 
            btnSepia.Location = new Point(608, 642);
            btnSepia.Name = "btnSepia";
            btnSepia.Size = new Size(115, 45);
            btnSepia.TabIndex = 7;
            btnSepia.Text = "Sepia";
            btnSepia.UseVisualStyleBackColor = true;
            btnSepia.Click += btnSepia_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 458);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 8;
            label1.Text = " Original Image Preview";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 544);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 10;
            label3.Text = "Image Processing Operations:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 544);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 11;
            label4.Text = "Image File Operations:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(599, 458);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 12;
            label2.Text = "Processed Image Preview";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 736);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnSepia);
            Controls.Add(btnHistogram);
            Controls.Add(btnInvert);
            Controls.Add(btnGrayScale);
            Controls.Add(btnBasicCopy);
            Controls.Add(btnSaveImage);
            Controls.Add(btnLoadImage);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Basic Image Processing Program";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnLoadImage;
        private OpenFileDialog openFileDialog1;
        private Button btnSaveImage;
        private Button btnBasicCopy;
        private Button btnGrayScale;
        private Button btnInvert;
        private Button btnHistogram;
        private Button btnSepia;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
    }
}