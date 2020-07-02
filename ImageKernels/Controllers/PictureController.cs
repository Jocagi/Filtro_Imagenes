using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageKernels
{
    public class PictureController
    {
        public static Bitmap convertToGrayScale(Bitmap bmp)
        {
            Bitmap newPicture = new Bitmap(bmp.Width, bmp.Height);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    
                    //Using YUV weights
                    int grayScale = (int)(
                                            (pixelColor.R * .299) +
                                            (pixelColor.G * .587) + 
                                            (pixelColor.B * .114));
                    
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    newPicture.SetPixel(x, y, newColor);
                }
            }

            return newPicture;
        }

        public static Bitmap convertToSepia(Bitmap bmp)
        {
            bmp = convertToGrayScale(bmp);
            Bitmap newPicture = new Bitmap(bmp.Width, bmp.Height);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    
                    Color newColor = Color.FromArgb(pixelColor.R, Convert.ToInt16(pixelColor.G * .95), Convert.ToInt16(pixelColor.B * .82));
                    newPicture.SetPixel(x, y, newColor);
                }
            }

            return newPicture;
        }
    }
}
