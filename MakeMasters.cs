using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

class Runner {
    private static void Main(string[] args) {
        
        string cwd = Directory.GetCurrentDirectory();
        string[] files = Directory.GetFiles(cwd, "*.qrcode.png");
        for (int i = 0; i < files.Length; i++) {
            string fileName = files[i];
            string outFileName = fileName.Replace(".qrcode.", ".sticker.");
            
            Console.WriteLine("Processing {0}", fileName);
            using(Bitmap template = new Bitmap("maker-faire-game.png")) {
                using (Graphics gfx = Graphics.FromImage(template)) {
                    using(Bitmap qrCode = new Bitmap(fileName)) {
                        gfx.DrawImage(qrCode, 685, 190, 490, 490);
                        template.Save(outFileName, ImageFormat.Png);
                    }
                }
            }
        }
    }
}