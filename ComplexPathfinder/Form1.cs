using ComplexPathfinderCore;
using ComplexPathfinderCore.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ComplexPathfinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Int32 startX = 0;
        Int32 startY = 0;
        Int32 targetX = 0;
        Int32 targetY = 0;

        private Color calculateColor(MapSquare square)
        {
            if (square.Neighbors.Any() &&
                square.Neighbors.All(n => square.SquareHight - n.SquareHight > Pathfinder.MaxSquareHightDelta || square.SquareHight >= 999 || square.SquareBadness >= 999))
            {
                return Color.Black;
            }

            Double HeightDelta = 0;
            if (square.Neighbors.Any())
            {
                HeightDelta = square.Neighbors.Average(neighbor => Math.Abs(square.SquareHight - neighbor.SquareHight));
            }

            Double normalizedHeightDifference = Math.Min(HeightDelta / Pathfinder.MaxSquareHightDelta, 1.0);
            Double badness = (square.SquareBadness + normalizedHeightDifference) / 2.0;
            Int32 greenComponent = (Int32)((1 - badness) * 255);
            greenComponent = Math.Min(Math.Max(greenComponent, 0), 255);

            return Color.FromArgb(255 - greenComponent, greenComponent, 0);
        }

        private void DrawMap()
        {
            Bitmap image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int y = 0; y < Pathfinder.UsingMap.Height; y++)
            {
                for (int x = 0; x < Pathfinder.UsingMap.Width; x++)
                {
                    MapSquare square = Pathfinder.UsingMap.SquareMatrix[y][x];
                    Color color = calculateColor(square);

                    Int32 pixelWidth = pictureBox1.Width / Pathfinder.UsingMap.Width;
                    Int32 pixelHeight = pictureBox1.Height / Pathfinder.UsingMap.Height;
                    for (int dx = 0; dx < pixelWidth; dx++)
                    {
                        for(int dy = 0; dy < pixelHeight; dy++)
                        {
                            image.SetPixel(x * pixelWidth + dx, y * pixelHeight + dy, color);
                        }
                    }
                    
                }
            }
            pictureBox1.Image = image;
        }

        private void DrawPath(List<MapSquare> path)
        {
            Bitmap image = (Bitmap)pictureBox1.Image;
            foreach (MapSquare square in path)
            {
                Int32 x = square.X;
                Int32 y = square.Y;
                Int32 pixelWidth = pictureBox1.Width / Pathfinder.UsingMap.Width;
                Int32 pixelHeight = pictureBox1.Height / Pathfinder.UsingMap.Height;

                Int32 red = image.GetPixel(x * pixelWidth, y * pixelHeight).R;
                Int32 green = image.GetPixel(x * pixelWidth, y * pixelHeight).G;
                for (int dx = 0; dx < pixelWidth; dx++)
                {
                    for (int dy = 0; dy < pixelHeight; dy++)
                    {
                        image.SetPixel(x * pixelWidth + dx, y * pixelHeight + dy, Color.FromArgb(red, green, 255));
                    }
                }
            }
            pictureBox1.Image = image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pathfinder.Load("PathfinderMap.txt", 0.75);
            startX = 0;
            startY = 0;
            targetX = Pathfinder.UsingMap.Width - 1;
            targetY = Pathfinder.UsingMap.Height - 1;

            DrawMap();
            List<MapSquare> path = Pathfinder.Pathfind(startX, startY, targetX, targetY);
            DrawPath(path);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startX = e.X * Pathfinder.UsingMap.Width / pictureBox1.Width;
                startY = e.Y * Pathfinder.UsingMap.Height / pictureBox1.Height;
            }
            else if (e.Button == MouseButtons.Right)
            {
                targetX = e.X * Pathfinder.UsingMap.Width / pictureBox1.Width;
                targetY = e.Y * Pathfinder.UsingMap.Height / pictureBox1.Height;
            }
            
            DrawMap();
            List<MapSquare> path = Pathfinder.Pathfind(startX, startY, targetX, targetY);
            DrawPath(path);
        }
    }
}
