using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexPathfinderCore.Util
{
    public class Map
    {
        public List<List<MapSquare>> SquareMatrix { get; protected set; }
        public Int32 Width;
        public Int32 Height;

        private void SetMapSquaresNeighbors()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    MapSquare upSquare = null;
                    MapSquare downSquare = null;
                    MapSquare leftSquare = null;
                    MapSquare rightSquare = null;

                    if (x - 1 >= 0) leftSquare = SquareMatrix[y][x-1];
                    if (x + 1 < Width) rightSquare = SquareMatrix[y][x+1];
                    if (y - 1 >= 0) upSquare = SquareMatrix[y-1][x];
                    if (y + 1 < Height) downSquare = SquareMatrix[y+1][x];

                    List<MapSquare> neigbors = new List<MapSquare>();
                    if (upSquare != null) neigbors.Add(upSquare);
                    if (downSquare != null) neigbors.Add(downSquare);
                    if (leftSquare != null) neigbors.Add(leftSquare);
                    if (rightSquare != null) neigbors.Add(rightSquare);
                    SquareMatrix[y][x].SetNeighbors(neigbors);
                }
            }
        }

        private List<Object> parseLine(String line, Char separator)
        {
            List<Object> result = new List<Object>();
            String currentData = "";

            for (Int32 i = 0; i < line.Length; i++)
            {
                Char currentChar = line[i];
                if (currentChar == separator)
                {
                    result.Add(currentData);
                    currentData = "";
                    continue;
                }

                currentData += currentChar.ToString();
            }
            if (currentData != "") result.Add(currentData);
            return result;
        }

        internal Map(Int32 Width, Int32 Height)
        {
            this.Width = Width;
            this.Height = Height;
            SquareMatrix = new List<List<MapSquare>>();

            Random random = new Random();
            
            for (int y = 0; y < Height; y++)
            {
                List<MapSquare> mapLine = new List<MapSquare>();
                for (int x = 0; x < Width; x++)
                {
                    MapSquare square = new MapSquare(
                        x, y,
                        random.NextDouble(),
                        random.NextDouble());
                    mapLine.Add(square);
                }
                SquareMatrix.Add(mapLine);
            }

            SetMapSquaresNeighbors();
        }

        internal Map(String FilePath)
        {
            
            using (StreamReader reader = new StreamReader(FilePath))
            {
                String line = reader.ReadLine();
                List<Object> data = parseLine(line, '|');
                Width = Convert.ToInt32(data[0]);
                Height = Convert.ToInt32(data[1]);
                SquareMatrix = new List<List<MapSquare>>();
                for (int y = 0; y < Height; y++)
                {
                    List<MapSquare> row = new List<MapSquare>();
                    for (int x = 0; x < Width; x++)
                    {
                        row.Add(null);
                    }
                    SquareMatrix.Add(row);
                }

                while ((line = reader.ReadLine()) != null)
                {
                    data = parseLine(line, '|');
                    Int32 x = Convert.ToInt32(data[0]);
                    Int32 y = Convert.ToInt32(data[1]);
                    Double badness = Convert.ToDouble(data[2]);
                    Double hight = Convert.ToDouble(data[3]);
                    MapSquare square = new MapSquare(x, y, badness, hight);
                    if (x < Width && y < Height) SquareMatrix[y][x] = square;
                }
            }

            SetMapSquaresNeighbors();
        }
    }
}
