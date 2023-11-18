namespace DipCs
{
    public partial class Form1 : Form
    {
        Bitmap loadImage, resultImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loadImage = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loadImage;
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            saveFileDialog1.FileName = Path.ChangeExtension(saveFileDialog1.FileName, "png");
            resultImage.Save(saveFileDialog1.FileName);
        }

        private void btnLoadImage_Click(object sender, EventArgs e)     // LOAD AN IMAGE
        {
            openFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tif;*.tiff";
            openFileDialog1.ShowDialog();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)     // SAVE PROCESSED IMAGE
        {
            if (pictureBox2.Image != null)
            {
                saveFileDialog1.ShowDialog();
            }
        }

        private void btnBasicCopy_Click(object sender, EventArgs e)     // BASIC COPY
        {
            if (pictureBox1.Image != null)
            {
                resultImage = new Bitmap(loadImage.Width, loadImage.Height);

                for (int x = 0; x < loadImage.Width; x++)
                {
                    for (int y = 0; y < loadImage.Height; y++)
                    {
                        Color pixel = loadImage.GetPixel(x, y);
                        resultImage.SetPixel(x, y, pixel);
                    }

                    pictureBox2.Image = resultImage;
                }
            }
        }

        private void btnGrayScale_Click(object sender, EventArgs e)     // GRAYSCALE
        {
            if (pictureBox1.Image != null)
            {
                resultImage = new Bitmap(loadImage.Width, loadImage.Height);

                for (int x = 0; x < loadImage.Width; x++)
                {
                    for (int y = 0; y < loadImage.Height; y++)
                    {
                        Color pixel = loadImage.GetPixel(x, y);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;
                        resultImage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                    }

                    pictureBox2.Image = resultImage;
                }
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)        // COLOR INVERSION
        {
            if (pictureBox1.Image != null)
            {
                resultImage = new Bitmap(loadImage.Width, loadImage.Height);

                for (int x = 0; x < loadImage.Width; x++)
                {
                    for (int y = 0; y < loadImage.Height; y++)
                    {
                        Color pixel = loadImage.GetPixel(x, y);
                        resultImage.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                    }

                    pictureBox2.Image = resultImage;
                }
            }
        }

        private void btnHistogram_Click(object sender, EventArgs e)     // HISTOGRAM
        {
            if (pictureBox1.Image != null)
            {
                resultImage = new Bitmap(loadImage.Width, loadImage.Height);
                for (int x = 0; x < loadImage.Width; x++)
                {
                    for (int y = 0; y < loadImage.Height; y++)
                    {
                        Color pixel = loadImage.GetPixel(x, y);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;
                        resultImage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                    }
                }

                Color sample;
                int[] histogramData = new int[256];

                for (int x = 0; x < loadImage.Width; x++)
                {
                    for (int y = 0; y < loadImage.Height; y++)
                    {
                        sample = resultImage.GetPixel(x, y);
                        histogramData[sample.R]++;
                    }
                }

                int graphDataWidth = 256;
                int graphDataHeight = 800;
                Bitmap graphData = new Bitmap(graphDataWidth, graphDataHeight);

                for (int x = 0; x < graphDataWidth; x++)
                {
                    for (int y = 0; y < graphDataHeight; y++)
                    {
                        graphData.SetPixel(x, y, Color.White);
                    }
                }

                // Plot histogramData
                for (int x = 0; x < graphDataWidth; x++)
                {
                    for (int y = 0; y < Math.Min(histogramData[x] / 5, graphDataHeight); y++)
                    {
                        graphData.SetPixel(x, (graphDataHeight - 1) - y, Color.Black);
                    }
                }

                pictureBox2.Image = graphData;
            }
        }

        private void btnSepia_Click(object sender, EventArgs e)     // SEPIA
        {
            if (pictureBox1.Image != null)
            {
                resultImage = new Bitmap(loadImage.Width, loadImage.Height);

                for (int x = 0; x < loadImage.Width; x++)
                {
                    for (int y = 0; y < loadImage.Height; y++)
                    {
                        Color pixel = loadImage.GetPixel(x, y);
                        resultImage.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));

                        int r = (int)((pixel.R * 0.393) + (pixel.G * 0.769) + (pixel.B * 0.189));
                        int g = (int)((pixel.R * 0.349) + (pixel.G * 0.686) + (pixel.B * 0.168));
                        int b = (int)((pixel.R * 0.272) + (pixel.G * 0.534) + (pixel.B * 0.131));

                        r = Math.Min(255, Math.Max(0, r));
                        g = Math.Min(255, Math.Max(0, g));
                        b = Math.Min(255, Math.Max(0, b));

                        resultImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }

                    pictureBox2.Image = resultImage;
                }
            }
        }
    }
}