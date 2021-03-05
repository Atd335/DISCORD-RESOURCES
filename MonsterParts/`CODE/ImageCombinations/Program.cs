using System;
using System.Collections.Generic;
using System.Resources;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace ImageCombinations
{
    class Program
    {

        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                for (int ii = 0; ii < 5; ii++)
                {
                    createImage(4, i, ii);
                }
            }
            //createImage(4, 0, 0);
        }
        
        static void createImage(int body, int mouth, int eye)
        {
            String png1 = $@"D:\REAL CODE\PROJECTS\1 -Discord bot\DISCORDFILES\DiscordResources\DISCORD-RESOURCES\MonsterParts\Bodies\Body_{body}.png";
            String png2 = $@"D:\REAL CODE\PROJECTS\1 -Discord bot\DISCORDFILES\DiscordResources\DISCORD-RESOURCES\MonsterParts\Eyes\Eyes_{eye}.png";
            String png3 = $@"D:\REAL CODE\PROJECTS\1 -Discord bot\DISCORDFILES\DiscordResources\DISCORD-RESOURCES\MonsterParts\Mouths\Mouth_{mouth}.png";
            String png4 = $@"D:\REAL CODE\PROJECTS\1 -Discord bot\DISCORDFILES\DiscordResources\DISCORD-RESOURCES\MonsterParts\OUTPUT\Body {body}\{body}_{eye}_{mouth}.png";

            Image img1 = Image.FromFile(png1);
            Image img2 = Image.FromFile(png2);
            Image img3 = Image.FromFile(png3);

            //int width = img1.Width + img2.Width;
            //int height = Math.Max(img1.Height, img2.Height);
            int width = 256;
            int height = 256;

            Bitmap img4 = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(img4);
            int y1 = 30;
            int x1 = 45;
            g.Clear(Color.Transparent);
            g.DrawImage(img1, new Point(0, 0));
            g.DrawImage(img2, new Point(x1, y1));//eyes
            g.DrawImage(img3, new Point(x1, y1+25));//Mouth

            g.Dispose();
            img1.Dispose();
            img2.Dispose();
            img3.Dispose();

            img4.Save(png4, System.Drawing.Imaging.ImageFormat.Png);
            img4.Dispose();
        }

    }
}
