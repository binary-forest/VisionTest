using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;


namespace VisionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        // =================================================================================
        // Video effects.
        // =================================================================================
        #region Video effects
        public static void DrawCrossFunct(ref Bitmap img, int x, int y)
        {
            Pen pen = new Pen(Color.Red, 1);
            Graphics g = Graphics.FromImage(img);
            g.DrawLine(pen, x / 2, 0, x / 2, y);
            g.DrawLine(pen, 0, y / 2, x, y / 2);
            pen.Dispose();
            g.Dispose();
        }

        #endregion

        private void cbCameraList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
