using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LPNR.Entities
{
    public static class UploadFile
    {
        public static System.Drawing.Image resimYukle(string resimYolu)
        {
            Bitmap resim = new Bitmap(resimYolu);

            if (resim.Width >= 480 || resim.Height >= 360)
            {
                float katsayi;
                int genislik;
                int yukseklik;

                if (resim.Width - 480 > resim.Height - 360)
                {
                    katsayi = (float)480 / resim.Width;
                    genislik = 480;
                    yukseklik = (int)(katsayi * resim.Height);
                }
                else
                {
                    katsayi = (float)360 / resim.Height;
                    yukseklik = 360;
                    genislik = (int)(katsayi * resim.Width);
                }
                Bitmap boyutlandirilmis = new Bitmap(genislik, yukseklik);
                Graphics grafik = Graphics.FromImage(boyutlandirilmis);
                grafik.DrawImage(resim, 0, 0, genislik, yukseklik);
                return boyutlandirilmis;
            }
            else return resim;
        }

        public static System.Drawing.Image resimYukleImage(System.Drawing.Image resim)
        {

            if (resim.Width >= 480 || resim.Height >= 360)
            {
                float katsayi;
                int genislik;
                int yukseklik;

                if (resim.Width - 480 > resim.Height - 360)
                {
                    katsayi = (float)480 / resim.Width;
                    genislik = 480;
                    yukseklik = (int)(katsayi * resim.Height);
                }
                else
                {
                    katsayi = (float)360 / resim.Height;
                    yukseklik = 360;
                    genislik = (int)(katsayi * resim.Width);
                }
                Bitmap boyutlandirilmis = new Bitmap(genislik, yukseklik);
                Graphics grafik = Graphics.FromImage(boyutlandirilmis);
                grafik.DrawImage(resim, 0, 0, genislik, yukseklik);
                return boyutlandirilmis;
            }
            else return resim;
        }

    }
}
