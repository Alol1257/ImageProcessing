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
        private Image<Bgr, byte> SourceImage;
        private Image<Bgr, byte> CropImage;
        private Image<Bgr, byte> CopySourseImage;
        private Image<Bgr, byte> CopyCropImage;

        private Rectangle Rect;
        private Point StartROI;

        private bool IsSelecting, IsMouseDown, IsCroped, IsDrew;

        private int SelectedOption;
        private int[] koef;

        public Form1()
        {
            InitializeComponent();

            Rect = Rectangle.Empty;
        }

        #region Описание событий для нажатия ЛКМ и триггеров отрисовки

        //Событие нажатия ЛКМ доступны только после события SelectROI_Click
        //Получаем координаты фильтруемой области как прямоугольник при нажатии и удерживании ЛКМ и движения мыши

        private void ImageBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(IsSelecting)
            {
                IsMouseDown = true;
                StartROI = e.Location;
            }
        }

        private void ImageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsSelecting)
            {
                int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
                int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
                Rect = new Rectangle(Math.Min(StartROI.X, e.X),
                           Math.Min(StartROI.Y, e.Y),
                           width,
                           height);
                Refresh();
            }
        }

        private void ImageBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsSelecting)
            {
                IsSelecting = false;
                IsMouseDown = false;
            }
        }

        //Триггеры для отрисовки

        private void ImageBox1_Paint(object sender, PaintEventArgs e)
        {
            if (IsMouseDown)
            {
                using (Pen pen = new Pen(Color.Blue, 2))
                {
                    e.Graphics.DrawRectangle(pen, Rect);
                }
            }          
        }

        private void ImageBox2_Paint(object sender, PaintEventArgs e)
        {
            if (IsDrew)
            {
                var winImage = CopyCropImage.CopyBlank();

                switch (SelectedOption)
                {
                    case 1:
                        e.Graphics.DrawImage(Filters.GrayFilter(CopyCropImage).AsBitmap(), StartROI);
                        break;

                    case 2:
                        e.Graphics.DrawImage(Filters.BrightnessFilter(CopyCropImage).AsBitmap(), StartROI);
                        break;

                    case 3:
                        e.Graphics.DrawImage(Filters.ContrastFilter(CopyCropImage).AsBitmap(), StartROI);
                        break;

                    case 4:
                        e.Graphics.DrawImage(Filters.HSVFilter(CopyCropImage.Convert<Hsv, byte>()).AsBitmap(), StartROI);
                        break;

                    case 5:
                        e.Graphics.DrawImage(Filters.SepiaFilter(CopyCropImage).AsBitmap(), StartROI);
                        break;

                    case 6:
                        e.Graphics.DrawImage(Filters.WinAll(CopyCropImage, winImage, -4, -2, 0, -2, 1, 2, 0, 2, 4).AsBitmap(), StartROI);
                        break;

                    case 7:
                        e.Graphics.DrawImage(Filters.WinAll(CopyCropImage, winImage, 0, 0, 0, -4, 4, 0, 0, 0, 0).AsBitmap(), StartROI);
                        break;

                    case 8:
                        e.Graphics.DrawImage(Filters.WinAll(CopyCropImage, winImage, koef).AsBitmap(), StartROI);
                        break;
                }
            }
        }

        #endregion

        #region Описания событий нажатия кнопок

        private void Open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы изображений (*.jpg,  *.jpeg,  *.jpe,  *.jfif,  *.png)  |  *.jpg;  *.jpeg;  *.jpe;  *.jfif; *.png"
            };
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                SourceImage = new Image<Bgr, byte>(fileName);

                float coefW = (float)SourceImage.Width / imageBox1.Width;
                float coefH = (float)SourceImage.Height / imageBox1.Height;

                if (coefW > 1 || coefH > 1)
                {
                    int imgHeight = (int)(SourceImage.Height / coefW);
                    int imgWidth = (int)(SourceImage.Width / coefH);

                    if (coefW > coefH)
                    {
                        SourceImage = SourceImage.Resize(imageBox1.Width, imgHeight, Inter.Linear);
                    }
                    else
                    {
                        SourceImage = SourceImage.Resize(imgWidth, imageBox1.Height, Inter.Linear);
                    }
                }

                imageBox1.Image = SourceImage.AsBitmap();

                CopySourseImage = SourceImage.Copy();

                imageBox2.Image = null;
                IsDrew = false;
                IsCroped = false;
            }
        }

        private void SelectROI_Click(object sender, EventArgs e)
        {
            //Активирует триггер для получения координат фильтруемой области

            IsSelecting = imageBox1.Image != null;

            IsDrew = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Файлы изображений (*.jpg,  *.jpeg,  *.jpe,  *.jfif,  *.png)  |  *.jpg;  *.jpeg;  *.jpe;  *.jfif; *.png"
            };

            var result = saveFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                Bitmap savedBit = new Bitmap(SourceImage.Width, SourceImage.Height);
                imageBox2.DrawToBitmap(savedBit, imageBox2.ClientRectangle);

                savedBit.Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void GetROI_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image == null)
                return;

            if (Rect == Rectangle.Empty)
                return;

            var img = new Bitmap(imageBox1.Image).ToImage<Bgr, byte>();

            img.ROI = Rect;
            var imgROI = img.Copy();
            img.ROI = Rectangle.Empty;

            IsCroped = true;

            CropImage = imgROI;
            CopyCropImage = CropImage.Copy();
        }

        // Все события фильтрации происходят по одному сценарию:

        // 1. Проверка, имеется ли область фильтрации

        // 2. Если имеется: - изображение и область фильтрации копируются
        //                  - происходит триггер события ImageBox2_Paint, при котором отрисовывается отфильтрованная область
        //                  - итоговое изображение выводится на экран

        // 3. Если отсутствует: - изображение копируется
        //                      - происходит фильтрация всего изображения
        //                      - итоговое изображение выводится на экран

        // Изменение свойств работает по такому же принципу

        private void Gray_btn_Click(object sender, EventArgs e)
        {
            if(SourceImage != null)
            {
                imageBox2.InitialImage = null;
                CopySourseImage = SourceImage.Copy();

                SelectedOption = 1;

                if (!IsCroped)
                {
                    imageBox2.Image = Filters.GrayFilter(CopySourseImage).AsBitmap();
                }
                else
                {
                    CopyCropImage = CropImage.Copy();

                    imageBox2.Image = SourceImage.AsBitmap();
                    IsDrew = true;
                }
            }
        }

        private void Sepia_btn_Click(object sender, EventArgs e)
        {
            if (SourceImage != null)
            {
                SelectedOption = 5;

                if (!IsCroped)
                {
                    CopySourseImage = SourceImage.Copy();
                    imageBox2.Image = Filters.SepiaFilter(CopySourseImage).AsBitmap();
                }
                else
                {
                    CopyCropImage = CropImage.Copy();

                    imageBox2.Image = SourceImage.AsBitmap();
                    IsDrew = true;
                }
            }
        }

        private void Embos_btn_Click(object sender, EventArgs e)
        {
            if (SourceImage != null)
            {
                SelectedOption = 6;

                if (!IsCroped)
                {
                    CopySourseImage = SourceImage.Copy();
                    var winImage = CopySourseImage.CopyBlank();

                    imageBox2.Image = Filters.WinAll(CopySourseImage, winImage, -4, -2, 0, -2, 1, 2, 0, 2, 4).AsBitmap();
                }
                else
                {
                    CopyCropImage = CropImage.Copy();

                    imageBox2.Image = SourceImage.AsBitmap();
                    IsDrew = true;
                }
            }
        }

        private void Edges_btn_Click(object sender, EventArgs e)
        {
            if (SourceImage != null)
            {
                SelectedOption = 7;

                if (!IsCroped)
                {
                    CopySourseImage = SourceImage.Copy();
                    var winImage = CopySourseImage.CopyBlank();

                    imageBox2.Image = Filters.WinAll(CopySourseImage, winImage, 0, 0, 0, -4, 4, 0, 0, 0, 0).AsBitmap();
                }
                else
                {
                    CopyCropImage = CropImage.Copy();

                    imageBox2.Image = SourceImage.AsBitmap();
                    IsDrew = true;
                }
            }     
        }

        private void UseFilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SourceImage != null)
                {
                    SelectedOption = 8;

                    int n1 = int.Parse(Num1.Text);
                    int n2 = int.Parse(Num2.Text);
                    int n3 = int.Parse(Num3.Text);
                    int n4 = int.Parse(Num4.Text);
                    int n5 = int.Parse(Num5.Text);
                    int n6 = int.Parse(Num6.Text);
                    int n7 = int.Parse(Num7.Text);
                    int n8 = int.Parse(Num8.Text);
                    int n9 = int.Parse(Num9.Text);

                    koef = new int[] { n1, n2, n3, n4, n5, n6, n7, n8, n9 };

                    if (!IsCroped)
                    {
                        CopySourseImage = SourceImage.Copy();
                        var winImage = CopySourseImage.CopyBlank();

                        imageBox2.Image = Filters.WinAll(CopySourseImage, winImage, koef).AsBitmap();
                    }
                    else
                    {
                        CopyCropImage = CropImage.Copy();

                        imageBox2.Image = SourceImage.AsBitmap();
                        IsDrew = true;
                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region Регулировка свойств посредством трекбаров

        private void BrightnessBar_Scroll(object sender, EventArgs e)
        {
            if (SourceImage != null)
            {
                SelectedOption = 2;

                Filters.Brightness = BrightnessBar.Value;

                if (!IsCroped)
                {
                    CopySourseImage = SourceImage.Copy();
                    imageBox2.Image = Filters.BrightnessFilter(CopySourseImage).AsBitmap();
                }
                else
                {
                    CopyCropImage = CropImage.Copy();

                    imageBox2.Image = SourceImage.AsBitmap();
                    IsDrew = true;
                }
            }
        }

        private void ContrastBar_Scroll(object sender, EventArgs e)
        {
            if (SourceImage != null)
            {
                Filters.Contrast = ContrastBar.Value;

                SelectedOption = 3;

                if (!IsCroped)
                {
                    CopySourseImage = SourceImage.Copy();
                    imageBox2.Image = Filters.ContrastFilter(CopySourseImage).AsBitmap();
                }
                else
                {
                    CopyCropImage = CropImage.Copy();

                    imageBox2.Image = SourceImage.AsBitmap();
                    IsDrew = true;
                }
            }
        }

        private void HSVBar_Scroll(object sender, EventArgs e)
        {
            if (SourceImage != null)
            {
                SelectedOption = 4;
                Filters.HSV = HSVBar.Value;

                if (!IsCroped)
                {
                    var copySourseImage = SourceImage.Convert<Hsv, byte>();
                    imageBox2.Image = Filters.HSVFilter(copySourseImage).AsBitmap();
                }
                else
                {
                    imageBox2.Image = SourceImage.AsBitmap();
                    IsDrew = true;
                }
            }
        }

        #endregion
    }
}