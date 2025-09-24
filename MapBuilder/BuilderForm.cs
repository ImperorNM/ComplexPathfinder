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
using static System.Windows.Forms.AxHost;

namespace MapBuilder
{
    public partial class BuilderForm : Form
    {
        public BuilderForm()
        {
            InitializeComponent();
        }
        private Int32 MapWidth = 32;
        private Int32 MapHeight = 32;
        private List<List<MapSquare>> matrix = new List<List<MapSquare>>();
        private Boolean CanvasCreated = false;
        private MapSquare SelectedSquare = null;
        private static readonly Random random = new Random();


        private void drawPixel(Bitmap canvas, Int32 x, Int32 y, Color color)
        {
            Int32 pixelWidth = Canvas_pictureBox.Width / MapWidth;
            Int32 pixelHeight = Canvas_pictureBox.Height / MapHeight;
            for (int dx = 0; dx < pixelWidth; dx++)
            {
                for (int dy = 0; dy < pixelHeight; dy++)
                {
                    canvas.SetPixel(x * pixelWidth + dx, y * pixelHeight + dy, color);
                }
            }
        }

        private void DrawBlankCanvas()
        {
            Bitmap image = new Bitmap(Canvas_pictureBox.Width, Canvas_pictureBox.Height);
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    if ((x + y) % 2 == 0) drawPixel(image, x, y, Color.Black);
                    else drawPixel(image, x, y, Color.White);
                }
            }
            Canvas_pictureBox.Image = image;
        }

        private void DrawCanvas()
        {
            Bitmap image = new Bitmap(Canvas_pictureBox.Width, Canvas_pictureBox.Height);
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    MapSquare square = matrix[y][x];
                    Color color = Color.FromArgb((Int32)Math.Round(square.SquareBadness * 255), (Int32)Math.Round((1 - square.SquareBadness) * 255), 0);
                    drawPixel(image, x, y, color);
                }
            }
            Canvas_pictureBox.Image = image;
        }

        private void BuilderForm_Load(object sender, EventArgs e)
        {
            DrawBlankCanvas();
        }

        private void NewCanvas_button_Click(object sender, EventArgs e)
        {
            MapWidth = Convert.ToInt32(NewCanvasWidth_textBox.Text);
            MapHeight = Convert.ToInt32(NewCanvasHeight_textBox.Text);
            matrix = new List<List<MapSquare>>();

            for (int y = 0; y < MapHeight; y++)
            {
                List<MapSquare> row = new List<MapSquare>();
                for (int x = 0; x < MapWidth; x++)
                {
                    row.Add(new MapSquare(x, y, random.NextDouble(), random.NextDouble()));
                }
                matrix.Add(row);
            }

            DrawCanvas();
            CanvasCreated = true;
        }

        private void NewSquare_textBox_TextChanged(object sender, EventArgs e)
        {
            Double badness = 0;
            Double height = 0;
            badness = NewSquareBadness_textBox.Text == "" ? 0 : Convert.ToDouble(NewSquareBadness_textBox.Text) / 100;
            badness = badness > 1 ? 1 : badness;
            badness = badness < 0 ? 0 : badness;
            height = NewSquareHeight_textBox.Text == "" ? 0 : Convert.ToDouble(NewSquareHeight_textBox.Text) / 100;
            height = height > 1 ? 1 : height;
            height = height < 0 ? 0 : height;

            Bitmap image = new Bitmap(NewSquarePreview_pictureBox.Width, NewSquarePreview_pictureBox.Height);
            for (int x = 0; x < NewSquarePreview_pictureBox.Width; x++)
            {
                for (int y = 0; y < NewSquarePreview_pictureBox.Height; y++)
                {
                    image.SetPixel(x, y, Color.FromArgb((Int32)Math.Round(badness * 255), (Int32)Math.Round((1 - badness) * 255), 0));
                }
            }
            NewSquarePreview_pictureBox.Image = image;
        }

        private void NewSquare_button_Click(object sender, EventArgs e)
        {
            Double badness = 0;
            Double height = 0;
            badness = NewSquareBadness_textBox.Text == "" ? 0 : Convert.ToDouble(NewSquareBadness_textBox.Text) / 100;
            badness = badness < 0 ? 0 : badness;
            height = NewSquareHeight_textBox.Text == "" ? 0 : Convert.ToDouble(NewSquareHeight_textBox.Text) / 100;
            height = height > 1 ? 1 : height;
            height = height < 0 ? 0 : height;

            SelectedSquare = new MapSquare(0, 0, badness, height);
        }

        private void Canvas_pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!CanvasCreated || e.Button != MouseButtons.Left) return;
            Int32 X = e.X * MapWidth / Canvas_pictureBox.Width;
            Int32 Y = e.Y * MapHeight / Canvas_pictureBox.Height;

            matrix[Y][X] = new MapSquare(X, Y, SelectedSquare.SquareBadness, SelectedSquare.SquareHight);
            
            Bitmap image = (Bitmap)Canvas_pictureBox.Image;
            drawPixel(image, X, Y, Color.FromArgb((Int32)Math.Round(SelectedSquare.SquareBadness > 1 ? 1 : SelectedSquare.SquareBadness * 255), (Int32)Math.Round((1 - (SelectedSquare.SquareBadness > 1 ? 1 : SelectedSquare.SquareBadness)) * 255), 0));
            Canvas_pictureBox.Image = image;
        }

        private void SaveFile_button_Click(object sender, EventArgs e)
        {
            List<String> lines = new List<String>();

            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    MapSquare square = matrix[y][x];
                    lines.Add($"{square.X}|{square.Y}|{square.SquareBadness}|{square.SquareHight}|");
                }
            }

            using (StreamWriter writer = new StreamWriter(FileName_textBox.Text, false))
            {
                writer.WriteLine($"{MapWidth}|{MapHeight}|");
                foreach (String line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
