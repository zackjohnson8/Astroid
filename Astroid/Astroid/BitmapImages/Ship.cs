using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Astroid.BitmapImages
{
    class Ship
    {

        enum Direction
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        }

        private Panel panel_m;
        private Image image_m;
        private PaintEventArgs PaintEventArgs_m;
        float width_m;
        float height_m;
        float x_m;
        float y_m;
        double area_m;

        public Ship(float x, float y, float width_p = 64, float height_p = 64)
        {
            //panel_m = printedForm;
            width_m = width_p;
            height_m = height_p;
            x_m = x;
            y_m = y;
            area_m = .5 * width_p * height_p;
            CreateShip();
        }

        private void CreateShip()
        {
            image_m = (Bitmap) Bitmap.FromFile(@"C:\Users\zack.johnson\Source\Repos\Astroid\Astroid\Astroid\Images\ship.png");
        }

        public void PaintToScreen(ref PaintEventArgs e)
        {
            PaintEventArgs_m = e;

            if (image_m == null)
            {
                image_m = Image.FromFile(@"C:\Users\zack.johnson\Source\Repos\Astroid\Astroid\Astroid\Images\ship.png");
            }
            // Draw image to screen.
            e.Graphics.DrawImage(image_m, x_m, y_m, width_m, height_m);
        }

        private void PaintToScreen(Direction dir)
        {
            if(dir == Direction.DOWN)
            {
                y_m = y_m + 10;
                //PaintEventArgs_m.Graphics.DrawImage(image_m, x_m, y_m, width_m, height_m);
            }else
            if(dir == Direction.UP)
            {
                y_m = y_m - 10;
            }else
            if(dir == Direction.LEFT)
            {
                x_m -= 10;
            }else
            if(dir == Direction.RIGHT)
            {
                x_m += 10;
            }
        }

        public void MoveDown()
        {
            if(PaintEventArgs_m != null)
            {
                PaintToScreen(Direction.DOWN);
            }
        }

        public void MoveUp()
        {
            if(PaintEventArgs_m != null)
            {
                PaintToScreen(Direction.UP);
            }
        }

        public void MoveLeft()
        {
            if (PaintEventArgs_m != null)
            {
                PaintToScreen(Direction.LEFT);
            }
        }

        public void MoveRight()
        {
            if (PaintEventArgs_m != null)
            {
                PaintToScreen(Direction.RIGHT);
            }
        }
    }
}
