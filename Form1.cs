using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage;
        private Image<Bgr, byte> cropImage;
        private Image<Bgr, byte> copySourseImage;
        private Image<Bgr, byte> copyCropImage;
        private Rectangle rect;
        private Point StartROI;
        private bool Selecting, MouseDown, Croped, Drew;
        private int selectedOption;

        public Form1()
        {
            InitializeComponent();

            Selecting = false;
            rect = Rectangle.Empty;
            Croped = false;
            Drew = false;
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Файлы изображений (*.jpg,  *.jpeg,  *.jpe,  *.jfif,  *.png)  |  *.jpg;  *.jpeg;  *.jpe;  *.jfif; *.png"
                };
                var result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    sourceImage = new Image<Bgr, byte>(fileName);

                    float coefW = (float)sourceImage.Width / imageBox1.Width;
                    float coefH = (float)sourceImage.Height / imageBox1.Height;

                    if (coefW > 1 || coefH > 1)
                    {
                        int imgHeight = (int)(sourceImage.Height / coefW);
                        int imgWidth = (int)(sourceImage.Width / coefH);

                        if (coefW > coefH)
                        {
                            sourceImage = sourceImage.Resize(imageBox1.Width, imgHeight, Inter.Linear);
                        }
                        else
                        {
                            sourceImage = sourceImage.Resize(imgWidth, imageBox1.Height, Inter.Linear);
                        }
                    }

                    imageBox1.Image = sourceImage.AsBitmap();

                    copySourseImage = sourceImage.Copy();

                    imageBox2.Image = null;
                    Drew = false;
                    Croped = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imageBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(Selecting)
            {
                MouseDown = true;
                StartROI = e.Location;
            }
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
                int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
                rect = new Rectangle(Math.Min(StartROI.X, e.X),
                           Math.Min(StartROI.Y, e.Y),
                           width,
                           height);
                Refresh();
            }
        }

        private void imageBox1_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.Blue, 2))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }          
        }

        private void getROI_Click(object sender, EventArgs e)
        {
            try
            {
                if(imageBox1.Image == null)
                    return;

                if (rect == Rectangle.Empty)
                    return;

                var img = new Bitmap(imageBox1.Image).ToImage<Bgr, byte>();

                img.ROI = rect;
                var imgROI = img.Copy();
                img.ROI = Rectangle.Empty;

                Croped = true;

                cropImage = imgROI;
                copyCropImage = cropImage.Copy();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gray_btn_Click(object sender, EventArgs e)
        {
            imageBox2.InitialImage = null;
            copySourseImage = sourceImage.Copy();

            selectedOption = 1;

            if (!Croped)
            {
                imageBox2.Image = Filters.GrayFilter(copySourseImage).AsBitmap();
            }
            else
            {
                copyCropImage = cropImage.Copy();

                imageBox2.Image = sourceImage.AsBitmap();
                Drew = true;
            }
        }

        private void sepia_btn_Click(object sender, EventArgs e)
        {
            imageBox2.InitialImage = null;

            selectedOption = 5;

            if (!Croped)
            {
                copySourseImage = sourceImage.Copy();
                imageBox2.Image = Filters.SepiaFilter(copySourseImage).AsBitmap();
            }
            else
            {
                copyCropImage = cropImage.Copy();

                imageBox2.Image = sourceImage.AsBitmap();
                Drew = true;
            }
        }

        private void embos_btn_Click(object sender, EventArgs e)
        {
            imageBox2.InitialImage = null;

            selectedOption = 6;

            if (!Croped)
            {
                copySourseImage = sourceImage.Copy();
                var winImage = copySourseImage.CopyBlank();

                imageBox2.Image = Filters.winAll(copySourseImage, winImage, -4, -2, 0, -2, 1, 2, 0, 2, 4).AsBitmap();
            }
            else
            {
                copyCropImage = cropImage.Copy();

                imageBox2.Image = sourceImage.AsBitmap();
                Drew = true;
            }
        }

        private void edges_btn_Click(object sender, EventArgs e)
        {
            imageBox2.InitialImage = null;

            selectedOption = 7;

            if (!Croped)
            {
                copySourseImage = sourceImage.Copy();
                var winImage = copySourseImage.CopyBlank();

                imageBox2.Image = Filters.winAll(copySourseImage, winImage, 0, 0, 0, -4, 4, 0, 0, 0, 0).AsBitmap();
            }
            else
            {
                copyCropImage = cropImage.Copy();

                imageBox2.Image = sourceImage.AsBitmap();
                Drew = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            imageBox2.InitialImage = null;

            selectedOption = 2;

            Filters.Brightness = trackBar1.Value;

            if (!Croped)
            {
                copySourseImage = sourceImage.Copy();
                imageBox2.Image = Filters.BrightnessFilter(copySourseImage).AsBitmap();
            }
            else
            {
                copyCropImage = cropImage.Copy();

                imageBox2.Image = sourceImage.AsBitmap();
                Drew = true;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            imageBox2.InitialImage = null;

            Filters.Contrast = trackBar2.Value;

            selectedOption = 3;

            if (!Croped)
            {
                copySourseImage = sourceImage.Copy();
                imageBox2.Image = Filters.ContrastFilter(copySourseImage).AsBitmap();
            }
            else
            {
                copyCropImage = cropImage.Copy();

                imageBox2.Image = sourceImage.AsBitmap();
                Drew = true;
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            imageBox2.InitialImage = null;

            selectedOption = 4;
            Filters.HSV = trackBar3.Value;

            if (!Croped)
            {
                var copySourseImage = sourceImage.Convert<Hsv, byte>();
                imageBox2.Image = Filters.HSVFilter(copySourseImage).AsBitmap();
            }
            else
            {
                imageBox2.Image = sourceImage.AsBitmap();
                Drew = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog
                {
                    Filter = "Файлы изображений (*.jpg,  *.jpeg,  *.jpe,  *.jfif,  *.png)  |  *.jpg;  *.jpeg;  *.jpe;  *.jfif; *.png"
                };

                var result = saveFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    imageBox2.Image.Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }

        private void imageBox2_Paint(object sender, PaintEventArgs e)
        {
            if (Drew)
            {
                var winImage = copyCropImage.CopyBlank();

                switch (selectedOption)
                {
                    case 1:
                        e.Graphics.DrawImage(Filters.GrayFilter(copyCropImage).AsBitmap(), StartROI);
                        break;

                    case 2:
                        e.Graphics.DrawImage(Filters.BrightnessFilter(copyCropImage).AsBitmap(), StartROI);
                        break;

                    case 3:
                        e.Graphics.DrawImage(Filters.ContrastFilter(copyCropImage).AsBitmap(), StartROI);
                        break;

                    case 4:
                        e.Graphics.DrawImage(Filters.HSVFilter(copyCropImage.Convert<Hsv, byte>()).AsBitmap(), StartROI);
                        break;

                    case 5:
                        e.Graphics.DrawImage(Filters.SepiaFilter(copyCropImage).AsBitmap(), StartROI);
                        break;

                    case 6:
                        e.Graphics.DrawImage(Filters.winAll(copyCropImage, winImage, -4, -2, 0, -2, 1, 2, 0, 2, 4).AsBitmap(), StartROI);
                        break;

                    case 7:
                        e.Graphics.DrawImage(Filters.winAll(copyCropImage, winImage, 0, 0, 0, -4, 4, 0, 0, 0, 0).AsBitmap(), StartROI);
                        break;       
                }
            }
        }

        private void imageBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                Selecting = false;
                MouseDown = false;
            }
        }

        private void selectROI_Click(object sender, EventArgs e)
        {
            Selecting = true;
        }
    }
}