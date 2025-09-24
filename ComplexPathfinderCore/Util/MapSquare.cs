using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexPathfinderCore.Util
{
    public class MapSquare
    {
        public Int32 X { get; protected set; }
        public Int32 Y { get; protected set; }
        public Double SquareBadness { get; protected set; }
        public Double SquareHight { get; protected set; }

        public List<MapSquare> Neighbors { get; protected set; }


        public MapSquare(Int32 X, Int32 Y, Double SquareBadness, Double SquareHight)
        {
            this.X = X;
            this.Y = Y;
            this.SquareBadness = SquareBadness;
            this.SquareHight = SquareHight;
            this.Neighbors = new List<MapSquare>();
        }

        internal void SetNeighbors(List<MapSquare> Neighbors)
        {
            this.Neighbors = Neighbors;
        }
    }
}
