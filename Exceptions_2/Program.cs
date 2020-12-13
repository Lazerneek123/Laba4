using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Exceptions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Directory.GetFiles(@"Pictures");
            string[] fileName = Directory.GetFiles(@"Pictures").Select(Path.GetFileName).ToArray();

            Regex regexExtForImage = new Regex("^((.bmp)|(.gif)|(.tiff?)|(.jpe?g)|(.png))$", RegexOptions.IgnoreCase);

            int n = 0;
            foreach (String i in fileName)
            {
                try
                {
                    if (regexExtForImage.IsMatch(Path.GetExtension(i)))
                    {                      
                        Bitmap bitmap = (Bitmap)Bitmap.FromFile(array[n]);
                        for (int j = 0; j < 200; ++j)
                        {
                            for (int j2 = 0; j2 < 200; ++j2)
                            {
                                bitmap.SetPixel(100 + j, 400 + j2, Color.Red);
                                bitmap.SetPixel(400 + j, 400 + j2, Color.Red);
                            }                            
                        }

                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
                        bitmap.Save(@"Res\" + i.Split('.')[0] + "-mirrored.gif", ImageFormat.Png);
                    }
                }
                catch (OutOfMemoryException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Ваша картинка успішно змінена!");
                    n++;
                }
            }

            Console.ReadKey();
        }
    }
}
