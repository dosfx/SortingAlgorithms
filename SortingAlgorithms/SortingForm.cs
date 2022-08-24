﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithms
{
    public partial class SortingForm : Form
    {
        private readonly EventWaitHandle waitHandle;
        private int[] sort;
        private Bitmap[] buffers;
        private int iBuf;
        private Rectangle graphBounds;

        public SortingForm()
        {
            DoubleBuffered = true;
            InitializeComponent();
            waitHandle = new AutoResetEvent(false);
            sort = Enumerable.Range(1, 500).ToArray();
            iBuf = 0;
        }

        private void Draw()
        {
            iBuf = (iBuf + 1) % 2;
            Bitmap current = buffers[iBuf];
            float barWidth = current.Width / (float)sort.Length;
            using (Graphics g = Graphics.FromImage(current))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                g.Clear(Color.Black);
                for (int i = 0; i < sort.Length; i++)
                {
                    float y = sort[i] / (float)sort.Length;
                    brush.Color = FromHue(sort[i], sort.Length);
                    g.FillRectangle(brush, i * barWidth, current.Height * (1 - y), barWidth, current.Height * y);
                }
            }

            // present buffer
            Invalidate();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Draw();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawImageUnscaled(buffers[iBuf], renderBox.Bounds);
            waitHandle.Set();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            graphBounds = new Rectangle(10, 10, renderBox.Width - 20, renderBox.Height - 20);
            buffers = new[] {
                new Bitmap(renderBox.Width, renderBox.Height),
                new Bitmap(renderBox.Width, renderBox.Height),
            };
        }

        private static Color FromHue(int value, double max)
        {
            return FromHue((value / max) * 360);
        }

        private static Color FromHue(double hue)
        {
            double h = hue / 60f;
            double x = 1 - Math.Abs((h % 2) - 1);
            double r = 0;
            double g = 0;
            double b = 0;
            if (0 <= h && h < 1)
            {
                r = 1;
                g = x;
            }
            else if (1 <= h && h < 2)
            {
                r = x;
                g = 1;
            }
            else if (2 <= h && h < 3)
            {
                g = 1;
                b = x;
            }
            else if (3 <= h && h < 4)
            {
                g = x;
                b = 1;
            }
            else if (4 <= h && h < 5)
            {
                r = x;
                b = 1;
            }
            else
            {
                r = 1;
                b = x;
            }
             
            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
        }

        private void RunWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Algorithm algorithm = (Algorithm)e.Argument;
            algorithm.Update += Algorithm_Update;
            algorithm.Run(sort);
        }

        private void Algorithm_Update(object sender, UpdateEventArgs e)
        {
            runWorker.ReportProgress(0, e);
            waitHandle.WaitOne();
        }

        private void RunWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Draw();
        }

        private void ShuffleLabel_Click(object sender, EventArgs e)
        {
            runWorker.RunWorkerAsync(new Shuffle());
        }
    }
}
