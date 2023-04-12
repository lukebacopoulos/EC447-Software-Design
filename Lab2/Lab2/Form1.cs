using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private ArrayList coordinates = new ArrayList();
        private ArrayList aligned_coords = new ArrayList();
        private ArrayList displayed_coords = new ArrayList();
        int buttoncount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                coordinates.Add(p);
                Invalidate();
            }
            if (e.Button == MouseButtons.Right)
            {
                coordinates.Clear();
                aligned_coords.Clear();
                Invalidate();
            }

            foreach (Point p in this.coordinates)
            {
                Point aligned = new Point();
                int remainderX;
                int remainderY;
                remainderX = p.X % 40;
                remainderY = p.Y % 40;

                if (remainderX < 20)
                {
                    aligned.X = p.X - remainderX;
                }

                else if (remainderX >= 20)
                {
                    aligned.X = p.X + (40 - remainderX);
                }

                if (remainderY < 20)
                {
                    aligned.Y = p.Y - remainderY;
                }

                else if (remainderY >= 20)
                {
                    aligned.Y = p.Y + (40 - remainderY);
                }
                aligned_coords.Add(aligned);
            }
            if (buttoncount % 2 == 0)
            {
                Invalidate();   
                displayed_coords = coordinates;
            }
            else if (buttoncount % 2 == 1)
            {
                Invalidate();
                displayed_coords = aligned_coords;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            int GRID = 40;
            int WIDTH = 20;
            int HEIGHT = 20;

            Graphics g = e.Graphics;
            int x = GRID;
            int y = GRID;

            while (x < ClientRectangle.Width)
            {
                g.DrawLine(Pens.Black, x, 0, x, ClientRectangle.Height);
                x += GRID;
            }
            while (y < ClientRectangle.Height)
            {
                g.DrawLine(Pens.Black, 0, y, ClientRectangle.Width, y);
                y += GRID;
            }

            foreach (Point p in this.displayed_coords)
            {
                g.FillEllipse(Brushes.Red,
                    p.X - WIDTH / 2, p.Y - HEIGHT / 2, WIDTH, HEIGHT);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttoncount++;
            button1.Text = button1.Text.EndsWith("Align") ? "Original" : "Align";
            if (displayed_coords == coordinates)
            {
                Invalidate();
                displayed_coords = aligned_coords;
            }
            else if (displayed_coords == aligned_coords)
            {
                Invalidate();
                displayed_coords = coordinates;
            }
        }
    }
}