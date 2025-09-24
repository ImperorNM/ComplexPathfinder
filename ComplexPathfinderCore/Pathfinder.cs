using ComplexPathfinderCore.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComplexPathfinderCore
{
    public static class Pathfinder
    {
        public static Map UsingMap { get; private set; }
        public static Double MaxSquareHightDelta { get; private set; }

        static Pathfinder()
        {
            UsingMap = new Map(32, 32);
        }

        private static Double calculateSquareCost(MapSquare currentSquare, MapSquare targetSquare)
        {
            Double cost = 0.0;

            Double hightDelta = Math.Abs(currentSquare.SquareHight - targetSquare.SquareHight);
            if (hightDelta > MaxSquareHightDelta) cost = 999999999999999;
            else cost = hightDelta * targetSquare.SquareBadness;
            
            return cost;
        }


        public static List<MapSquare> Pathfind(Int32 StartX, Int32 StartY, Int32 TargetX, Int32 TargetY)
        {
            List<MapSquare> result = new List<MapSquare>();
            Dictionary<MapSquare, Double> distances = new Dictionary<MapSquare, Double>();
            Dictionary<MapSquare, MapSquare> previous = new Dictionary<MapSquare, MapSquare>();
            List<MapSquare> unvisited = new List<MapSquare>();

            foreach (List<MapSquare> row in UsingMap.SquareMatrix)
            {
                foreach (MapSquare square in row)
                {
                    distances[square] = Double.MaxValue;
                    previous[square] = null;
                    unvisited.Add(square);
                }
            }

            MapSquare start = UsingMap.SquareMatrix[StartY][StartX];
            MapSquare target = UsingMap.SquareMatrix[TargetY][TargetX];
            distances[start] = 0;

            while (unvisited.Count > 0)
            {
                MapSquare current = unvisited.OrderBy(s => distances[s]).First();
                unvisited.Remove(current);

                if (current == target)
                {
                    while (previous[current] != null)
                    {
                        result.Insert(0, current);
                        current = previous[current];
                    }
                    result.Insert(0, start);
                    return result;
                }

                foreach (MapSquare neighbor in current.Neighbors)
                {
                    if (!unvisited.Contains(neighbor)) continue;

                    Double alt = distances[current] + calculateSquareCost(current, neighbor);
                    if (alt < distances[neighbor])
                    {
                        distances[neighbor] = alt;
                        previous[neighbor] = current;
                    }
                }
            }
            return result;
        }

        public static void Load(String File, Double MaxSquareHightDelta)
        {
            UsingMap = new Map(File);
            Pathfinder.MaxSquareHightDelta = MaxSquareHightDelta;
        }
    }
}
