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

        private Form form_m;
        private Image image_m;
        float width_m;
        float height_m;
        float x_m;
        float y_m;
        double area_m;

        public Ship(Form printedForm, float width_p = 64, float height_p = 64)
        {
            form_m = printedForm;
            width_m = width_p;
            height_m = height_p;
            x_m = printedForm.Size.Width/2 - width_m;
            y_m = printedForm.Size.Height/2 - height_m;
            area_m = .5 * width_p * height_p;
            CreateShip();
        }

        private void CreateShip()
        {
            image_m = (Bitmap) Bitmap.FromFile(@"C:\Users\zack.johnson\Source\Repos\Astroid\Astroid\Astroid\Images\ship.png");
        }

        public void PaintToScreen(ref PaintEventArgs e)
        {
            image_m = Image.FromFile(@"C:\Users\zack.johnson\Source\Repos\Astroid\Astroid\Astroid\Images\ship.png");

            // Draw image to screen.
            e.Graphics.DrawImage(image_m, x_m, y_m, width_m, height_m);
        }

    }
}
