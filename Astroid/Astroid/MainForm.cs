using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Astroid.AstroidUI;

namespace Astroid
{
    public partial class MainForm : Form
    {

        //Image bitmap_m;
        //BitmapImages.Ship ship_m;
        Game game_m;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Transparency(double opacityLevel = 1, bool transparencySetting = false)
        {
            if (transparencySetting)
            {
                this.AllowTransparency = transparencySetting;
                this.Opacity = opacityLevel;
            }
        }

        private void SetBitmapSolidColor(ref Bitmap bitmap, int width, int height, Color color)
        {
            int x;
            int y;

            for(x = 0; x < width; x++)
            {
                for(y = 0; y < height; y++)
                {
                    bitmap.SetPixel(x, y, color);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            game_m.Update(ref e);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (game_m == null)
            {
                game_m = new Game(ref panel1);
                game_m.StartGame();
                Task.Delay(2000);
            }

        }

        //private async Task StartGame()
        //{
        //   await game_m.StartGame(panel1);
        //}

        //private void Form1_KeyPress(Object sender, KeyPressEventArgs e)
        //{
        //Console.WriteLine()
        //e.KeyChar
        //if (e.KeyCode == Keys.Down)
        //{
        //    ship_m.MoveDown();
        //    panel1.Invalidate();
        //}
        //else
        //if (e.KeyCode == Keys.Up)
        //{
        //    ship_m.MoveUp();
        //    panel1.Invalidate();
        //}
        //else
        //if (e.KeyCode == Keys.Right)
        //{
        //    ship_m.MoveRight();
        //    panel1.Invalidate();
        //}
        //else
        //if (e.KeyCode == Keys.Left)
        //{
        //    ship_m.MoveLeft();
        //    panel1.Invalidate();
        //}
        //}

        //protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        //{
        //    base.OnPreviewKeyDown(e);
        //    if(e.KeyCode == Keys.Down)
        //    {
        //        ship_m.MoveDown();
        //        panel1.Invalidate();
        //    }else
        //    if (e.KeyCode == Keys.Up)
        //    {
        //        ship_m.MoveUp();
        //        panel1.Invalidate();
        //    }else
        //    if (e.KeyCode == Keys.Right)
        //    {
        //        ship_m.MoveRight();
        //        panel1.Invalidate();
        //    }else
        //    if (e.KeyCode == Keys.Left)
        //    {
        //        ship_m.MoveLeft();
        //        panel1.Invalidate();
        //    }
        //}
    }
}
