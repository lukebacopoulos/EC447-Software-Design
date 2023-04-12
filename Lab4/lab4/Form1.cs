using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace lab4
{
    public partial class Form1 : Form
    {


        //dimensions
        private const float clientSize = 100;
        private const float lineLength = 80;
        private const float block = lineLength / 3;
        private const float offset = 10;
        private const float delta = 5;
        private enum CellSelection { N, O, X };         
        private static CellSelection[,] grid = new      
            CellSelection[3, 3];                        
        private float scale; //current scale factor
        GameEngine Game = new GameEngine();
        private int winner;
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ApplyTransform(g);
            //draw board
            g.DrawLine(Pens.Black, block, 0, block, lineLength);
            g.DrawLine(Pens.Black, 2 * block, 0, 2 * block, lineLength);
            g.DrawLine(Pens.Black, 0, block, lineLength, block);
            g.DrawLine(Pens.Black, 0, 2 * block, lineLength, 2 * block);
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    if (grid[i, j] == CellSelection.O)
                        DrawO(i, j, g);
                    else if (grid[i, j] == CellSelection.X) DrawX(i, j, g);
        }
        private void ApplyTransform(Graphics g)         // doesnt need changing
        {
            scale = Math.Min(ClientRectangle.Width /
            clientSize, ClientRectangle.Height / clientSize);
            if (scale == 0f) return;
            g.ScaleTransform(scale, scale);
            g.TranslateTransform(offset, offset);
        }
        private void DrawX(int i, int j, Graphics g)        // doesnt need changing
        {
            g.DrawLine(Pens.Black, i * block + delta,
            j * block + delta,
            (i * block) + block - delta, (j * block) + block - delta);
            g.DrawLine(Pens.Black, (i * block) + block - delta,
            j * block + delta, (i * block) + delta,
            (j * block) + block - delta);

        }
        private void DrawO(int i, int j, Graphics g)        // doesnt need changing
        {
            g.DrawEllipse(Pens.Black, i * block + delta,
            j * block + delta,
            block - 2 * delta, block - 2 * delta);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            CPUStartsMenuItem.Enabled = false;
            Graphics g = CreateGraphics();
            ApplyTransform(g);
            PointF[] p = { new Point(e.X, e.Y) };
            g.TransformPoints(CoordinateSpace.World, CoordinateSpace.Device, p);
            if (p[0].X < 0 || p[0].Y < 0) return;
            int i = (int)(p[0].X / block);
            int j = (int)(p[0].Y / block);
            if (i > 2 || j > 2) return;

            if (e.Button == MouseButtons.Left)                   // checks for left click
                if (Game.CheckPlayerMove(i, j) == true)          //if coordinate on board, check if valid move, update accordingly
                    grid[i, j] = CellSelection.X;               
            Invalidate();

            winner = Game.CheckWin();            // after each player move, check for a win, computer moves
            DisplayWinner(winner);
            Game.ComputerMove();
            DisplayCPUMove(Game.grid);
            Invalidate();
            winner = Game.CheckWin();            // check if computer makes winning move
            DisplayWinner(winner);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewGameMenuItem_Click(object sender, EventArgs e)
        {
            Game.StartNewGame();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Game.grid[i,j] == 0)
                    {
                        grid[i, j] = CellSelection.N;
                    }
                }
            }
            Invalidate();
            CPUStartsMenuItem.Enabled = true;
        }

        private void CPUStartsMenuItem_Click(object sender, EventArgs e)
        {
            CPUStartsMenuItem.Enabled = false;          // disables menu item after click
            // computer makes first move
            Game.ComputerMove();
            DisplayCPUMove(Game.grid);
            Invalidate();
        }

        private void DisplayWinner(int w)
        {
            if (w == 1)
            {
                MessageBox.Show("Player Wins!");

            }
            else if (w == 2)
            {
                MessageBox.Show("Computer Wins!");
            }
        }
   
        private void DisplayCPUMove(int[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                
                    if (arr[i,j] == 2 && grid[i,j] == CellSelection.N)
                    {
                        grid[i, j] = CellSelection.O;
                    }

                }
            }

        }
    }



