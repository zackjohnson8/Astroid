﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astroid
{
    public partial class MainForm : Form
    {

        Bitmap bitmap;

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

            bitmap = new Bitmap(64, 64);
            SetBitmapSolidColor(ref bitmap, 64, 64, Color.Aqua);
            e.Graphics.DrawImage((Image)bitmap, new PointF(0,0));
        }
    }
}