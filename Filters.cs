using Emgu.CV;
using Emgu.CV.Structure;
using System;

namespace ImageProcessing
{
    public static class Filters
    {
        public static int Brightness { get; set; }
        public static int Contrast { get; set; }
        public static int HSV { get; set; }
        
        public static Image<Gray, byte> GrayFilter(Image<Bgr, byte> editableImage)
        {
            var grayImage = new Image<Gray, byte>(editableImage.Size);

            for (int y = 0; y < grayImage.Height; y++)
            {
                for (int x = 0; x < grayImage.Width; x++)
                {
                    grayImage.Data[y, x, 0] = Convert.ToByte(0.299 * editableImage.Data[y, x, 2] + 0.587 * editableImage.Data[y, x, 1] + 0.114 * editableImage.Data[y, x, 0]);
                }
            }

            return grayImage;
        }

        public static Image<Bgr, byte> BrightnessFilter(Image<Bgr, byte> editableImage)
        {
            for (int ch = 0; ch < 3; ch++)
            {
                for (int y = 0; y < editableImage.Height; y++)
                {
                    for (int x = 0; x < editableImage.Width; x++)
                    {
                        double color = editableImage.Data[y, x, ch] + Brightness;

                        if (Brightness < 0)
                        {
                            if (color < 0)
                                editableImage.Data[y, x, ch] = 0;
                            else
                                editableImage.Data[y, x, ch] = Convert.ToByte(color);
                        }
                        else
                        {
                            if (color > 255)
                                editableImage.Data[y, x, ch] = 255;
                            else
                                editableImage.Data[y, x, ch] = Convert.ToByte(color);
                        }
                    }
                }
            }        

            return editableImage;
        }

        public static Image<Bgr, byte> ContrastFilter(Image<Bgr, byte> editableImage)
        {
            for (int ch = 0; ch < 3; ch++)
            {
                for (int y = 0; y < editableImage.Height; y++)
                {
                    for (int x = 0; x < editableImage.Width; x++)
                    {
                        double color = editableImage.Data[y, x, ch] * Contrast * 0.1;

                        if (color > 255)
                            editableImage.Data[y, x, ch] = 255;
                        else if (color < 0)
                            editableImage.Data[y, x, ch] = 0;
                        else
                            editableImage.Data[y, x, ch] = Convert.ToByte(color);
                    }
                }
            }    

            return editableImage;
        }

        public static Image<Hsv, byte> HSVFilter(Image<Hsv, byte> editableImage)
        {
            for (int y = 0; y < editableImage.Height; y++)
            {
                for (int x = 0; x < editableImage.Width; x++)
                {
                    editableImage.Data[y, x, 0] = (byte)HSV;
                }
            }

            return editableImage;
        }

        public static Image<Bgr, byte> SepiaFilter(Image<Bgr, byte> editableImage)
        {
            for (int y = 0; y < editableImage.Height; y++)
            {
                for (int x = 0; x < editableImage.Width; x++)
                {
                    if ((0.393 * editableImage.Data[y, x, 2] + 0.769 * editableImage.Data[y, x, 1] + 0.189 * editableImage.Data[y, x, 0]) > 255)
                        editableImage.Data[y, x, 2] = 255;
                    else
                        editableImage.Data[y, x, 2] = Convert.ToByte(0.393 * editableImage.Data[y, x, 2] + 0.769 * editableImage.Data[y, x, 1] + 0.189 * editableImage.Data[y, x, 0]);

                    if ((0.349 * editableImage.Data[y, x, 2] + 0.686 * editableImage.Data[y, x, 1] + 0.168 * editableImage.Data[y, x, 0]) > 255)
                        editableImage.Data[y, x, 1] = 255;
                    else
                        editableImage.Data[y, x, 1] = Convert.ToByte(0.349 * editableImage.Data[y, x, 2] + 0.686 * editableImage.Data[y, x, 1] + 0.168 * editableImage.Data[y, x, 0]);

                    if ((0.272 * editableImage.Data[y, x, 2] + 0.534 * editableImage.Data[y, x, 1] + 0.131 * editableImage.Data[y, x, 0]) > 255)
                        editableImage.Data[y, x, 0] = 255;
                    else
                        editableImage.Data[y, x, 0] = Convert.ToByte(0.272 * editableImage.Data[y, x, 2] + 0.534 * editableImage.Data[y, x, 1] + 0.131 * editableImage.Data[y, x, 0]);
                }
            }

            return editableImage;
        }

        public static Image<Bgr, byte> WinAll(Image<Bgr, byte> editableImage, Image<Bgr, byte> winImg, params int[] v)
        {
            int[,] w;
            w = new int[3, 3]
            {
                {v[0],  v[1], v[2]},
                {v[3], v[4], v[5]},
                {v[6],  v[7], v[8]}
            };

            WindowFilter(editableImage, winImg, w);

            return winImg;
        }

        private static Image<Bgr, byte> WindowFilter(Image<Bgr, byte> editableImage, Image<Bgr, byte> winImg, int[,] v)
        {
            for (int ch = 0; ch < 3; ch++)
            {
                for (int y = 1; y < editableImage.Height - 1; y++)
                {
                    for (int x = 1; x < editableImage.Width - 1; x++)
                    {
                        int r = 0;

                        for (int i = -1; i < 2; i++)
                        {
                            for (int j = -1; j < 2; j++)
                            {
                                r += editableImage.Data[i + y, j + x, ch] * v[i + 1, j + 1];
                            }
                        }   

                        if (r > 255) 
                            r = 255;

                        if (r < 0) 
                            r = 0;

                        winImg.Data[y, x, ch] = (byte)r;
                    }
                }
            }

            return editableImage;
        }
    }
}