using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    class Rasterizer
    {
        public Bitmap Rasterize(int width, int height)
        {
            Size size = new Size(width, height);
            Bitmap image = new Bitmap(size.Width, size.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            return image;
        }
    }
}