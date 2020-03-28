using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astroid.BitmapImages;
using System.Windows.Forms;

namespace Astroid.AstroidUI
{

    public class UIFactory
    {
        public enum KeyPress
        {
            UP_ARROW,
            DOWN_ARROW,
            LEF_TARROW,
            RIGHT_ARROW
        }

        private Ship ship_m;
        private Panel panel_m;

        public UIFactory(ref Panel panel)
        {
            // Panel
            panel_m = panel;
            // Background

            // Ship
            CreateShip();

            // Astroids

            // Gun Fire
        }

        // only a single ship
        private bool CreateShip()
        {
            // Create a ship
            if (ship_m == null)
            {
                ship_m = new BitmapImages.Ship(panel_m.Size.Width / 2, panel_m.Size.Height / 2);
                return true;
            }
            return false;
        }

        // more than one astroids
        public bool CreateAstroid()
        {
            return false;
        }

        // more than one gun fire
        public bool CreateGunFire()
        {
            return false;
        }

        // only a single background
        private bool CreateBackground()
        {
            return false;
        }

        public void Update(ref PaintEventArgs e)
        {
            ship_m.PaintToScreen(ref e);
        }

        public void KeyPressHandle(KeyPress direction)
        {
            if(direction == KeyPress.UP_ARROW)
            {
                ship_m.MoveUp();
            }
        }

    }

}
