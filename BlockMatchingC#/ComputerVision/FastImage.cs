using System.Drawing;
using System.Drawing.Imaging;

namespace ComputerVision
{
    public class FastImage
    {
        public int Height = 0;
        public int Width = 0;
        private Bitmap image = null;
        private Rectangle rectangle;
        private BitmapData bitmapData = null;
        private Color color;
        private Point size;
        private int currentBitmapWidth = 0;

        struct PixelData
        {
            public byte red, green, blue;
        }

        public FastImage(Bitmap bitmap)
        {
            image = bitmap;
            Width = image.Width;
            Height = image.Height;
            size = new Point(image.Size);
            currentBitmapWidth = size.X;
        }

        public void Lock()
        {
            // Rectangle For Locking The Bitmap In Memory
            rectangle = new Rectangle(0, 0, image.Width, image.Height);
            // Get The Bitmap's Pixel Data From The Locked Bitmap
            bitmapData = image.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
        }

        public void Unlock()
        {
            image.UnlockBits(bitmapData);
        }

        public Color GetPixel(int col, int row)
        {
            unsafe
            {
                PixelData* pBase = (PixelData*)bitmapData.Scan0;
                PixelData* pPixel = pBase + row * currentBitmapWidth + col;
                color = Color.FromArgb(pPixel->red, pPixel->green, pPixel->blue);
            }
            return color;
        }

        public void SetPixel(int col, int row, Color c)
        {
            unsafe
            {
                PixelData* pBase = (PixelData*)bitmapData.Scan0;
                PixelData* pPixel = pBase + row * currentBitmapWidth + col;
                pPixel->red = c.R;
                pPixel->green = c.G;
                pPixel->blue = c.B;
            }
        }

        public Bitmap GetBitMap()
        {
            return image;
        }

    }

    public class ColorExtension
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public ColorExtension(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public ColorExtension()
        {

        }
    }
}
