using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotPic
{
    public partial class Form1 : Form
    {
        public class DotDot
        {
            public double x;
            public double y;
            public double r;

            public DotDot(double x, double y, double r)
            {
                this.x = x;

                this.y = y;

                if (r >= 1)
                    this.r = r;
                else
                    this.r = 1;
            }
        }

        Bitmap bmpOrg;
        Bitmap bmpDot;
        Graphics gc;
        Brush br;
        List<DotDot> lDot = new List<DotDot>();

        public Form1()
        {
            InitializeComponent();
        }

        private Color GetRGBSum(int x, int y, int r)
        {
            int sumR = 0;
            int sumG = 0;
            int sumB = 0;

            Color cl;

            for (int i = x; i < x + r; i++)
            {
                for (int j = y; j < y + r; j++)
                {
                    cl = bmpOrg.GetPixel(i, y);
                    sumR += cl.R;
                    sumG += cl.G;
                    sumB += cl.B;
                }
            }

            sumR /= (r * r);
            sumG /= (r * r);
            sumB /= (r * r);

            cl = Color.FromArgb(sumR, sumG, sumB);

            return cl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmpOrg = new Bitmap(this.pbxOrigin.Image);

            Color cl = GetRGBSum(0, 0, bmpOrg.Width);

            //this.lblRValue.Text = sumR.ToString();
            //this.lblGValue.Text = sumG.ToString();
            //this.lblBValue.Text = sumB.ToString();

            bmpDot = new Bitmap(this.pbxDot.Image);
            gc = Graphics.FromImage(bmpDot);
            gc.Clear(Color.White);

            br = new SolidBrush(cl);
            Rectangle rct = new Rectangle(0, 0, bmpDot.Width, bmpDot.Height);

            gc.FillEllipse(br, rct);

            this.pbxDot.Image = bmpDot;

            lDot.Add(new DotDot(bmpDot.Width / 2, bmpDot.Height / 2, bmpDot.Width / 2));
        }

        private void pbxDot_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void pbxDot_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            double mx = 0;
            double my = 0;
            double mr = 0;
            bool flag = false;

            foreach (DotDot mDot in lDot)
            {
                if (mDot.r <= 4)
                    continue;

                if ((Math.Pow((x - mDot.x), 2) + Math.Pow((y - mDot.y), 2)) <= Math.Pow(mDot.r, 2))
                {
                    mx = (double)Math.Round(mDot.x);
                    my = (double)Math.Round(mDot.y);
                    mr = (double)Math.Round(mDot.r);

                    lDot.Remove(mDot);

                    flag = true;

                    break;
                }
            }

            if (flag)
            {
                Rectangle rct = new Rectangle((int)(mx - mr), (int)(my - mr), (int)(mr * 2), (int)(mr * 2));
                br = new SolidBrush(Color.White);
                gc.FillRectangle(br, rct);

                pbxDot.Image = bmpDot;


                Color cl = GetRGBSum((int)(mx - mr), (int)(my - mr), (int)(mr));
                br = new SolidBrush(cl);
                rct = new Rectangle((int)(mx - mr), (int)(my - mr), (int)(mr), (int)(mr));
                gc.FillEllipse(br, rct);
                lDot.Add(new DotDot(mx - mr / 2, my - mr / 2, mr / 2));

                cl = GetRGBSum((int)(mx - mr), (int)(my), (int)(mr));
                br = new SolidBrush(cl);
                rct = new Rectangle((int)(mx - mr), (int)(my), (int)(mr), (int)(mr));
                gc.FillEllipse(br, rct);
                lDot.Add(new DotDot(mx - mr / 2, my + mr / 2, mr / 2));

                cl = GetRGBSum((int)(mx), (int)(my - mr), (int)(mr));
                br = new SolidBrush(cl);
                rct = new Rectangle((int)(mx), (int)(my - mr), (int)(mr), (int)(mr));
                gc.FillEllipse(br, rct);
                lDot.Add(new DotDot(mx + mr / 2, my - mr / 2, mr / 2));

                cl = GetRGBSum((int)(mx), (int)(my), (int)(mr));
                br = new SolidBrush(cl);
                rct = new Rectangle((int)(mx), (int)(my), (int)(mr), (int)(mr));
                gc.FillEllipse(br, rct);
                lDot.Add(new DotDot(mx + mr / 2, my + mr / 2, mr / 2));

                pbxDot.Image = bmpDot;
            }
        }
    }
}
