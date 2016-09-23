using System;
using System.Collections.Generic;

namespace Sept10th2016
{
    class Sept10Th2016
    {
        // Use to get row and column numbers of 4 neighbours of a given cell
        // Ex : left right up down
        public static int[] RowNumber = { -1, 0, 0, 1 };
        public static int[] ColNumber = { 0, -1, 1, 0 };

        public static void Main(string[] args)
        {
            int p = 0, q = 0, x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            Byte[,] inputMatrix = new byte[,] { };
            var line1 = Console.ReadLine();
            if (line1 != null)
            {
                p = Convert.ToInt32(line1.Trim());
            }
            var line2 = Console.ReadLine();
            if (line2 != null)
            {
                q = Convert.ToInt32(line2.Trim());
            }
            var line3 = Console.ReadLine();
            if (line3 != null)
            {
                string[] inArr = line3.Trim().Split(new[] { ' ', ',' });
                inputMatrix = new byte[p, q];
                int k = 0;
                for (int i = 0; i < p; i++)
                {
                    for (int j = 0; j < q; j++)
                    {
                        inputMatrix[i, j] = Convert.ToByte(inArr[k++]);
                    }
                }
            }
            string line4 = Console.ReadLine();
            if (line4 != null)
            {
                string[] firstPoint = line4.Trim().Split(new char[] { ' ', ',' });
                x1 = Convert.ToInt32(firstPoint[0]);
                y1 = Convert.ToInt32(firstPoint[1]);
            }
            string line5 = Console.ReadLine();
            if (line5 != null)
            {
                string[] secondPoint = line5.Trim().Split(new char[] { ' ', ',' });
                x2 = Convert.ToInt32(secondPoint[0]);
                y2 = Convert.ToInt32(secondPoint[1]);
            }

            // Creating starting and ending points
            CoOrdinate start, end;
            start.X = x1;
            start.Y = y1;
            end.X = x2;
            end.Y = y2;
            int shortestPath = GetShortestPath(start, end, p, q, inputMatrix);
            Console.WriteLine(shortestPath != -1 ? "YES " + shortestPath : "NO");

            Console.ReadKey();
        }

        /// <summary>
        /// Calculate shortest path distance for given start to an end point
        /// I have used Breadth First Search (BFS) algorithm to get the shortest path from source to destination
        /// 
        /// *****************************************************************************************************
        /// Algorithm :
        /// 
        /// BFS(Graph G, Start Vertex S)
        /// [All nodes initially unexplored]
        /// - Mark S as explored
        /// - Let Q = queue data structure (FIFO), initiated with S
        /// - While Q not Empty
        ///     - Remove the frist node of Q, call it V
        ///     - For each edge (V, w)
        ///         - If W unexplored
        ///	            - Mark W as explored
        ///	            - Add W to Q (At the end)
        /// ******************************************************************************************************
        /// Time Complexity : O(p * q)
        /// Space Complexity Approximate : O(p * q)
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <param name="inputMatrix"></param>
        /// <returns></returns>
        public static int GetShortestPath(CoOrdinate start, CoOrdinate end, int p, int q, Byte[,] inputMatrix)
        {
            //Start and end co-ordinate should have 1 value
            if (inputMatrix[start.X, start.Y] == 0 || inputMatrix[end.X, end.Y] == 0)
            {
                return -1;
            }

            // Mark all cells as not visited
            Boolean[,] visitedCell = new bool[p, q];
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    visitedCell[i, j] = false;
                }
            }

            visitedCell[start.X, start.Y] = true;

            Queue<Cell> queue = new Queue<Cell>();
            Cell cell;
            cell.Distance = 0;
            cell.Point = start;
            queue.Enqueue(cell);

            while (queue.Count > 0)
            {
                Cell currNode = queue.Peek();
                CoOrdinate point = currNode.Point;

                // Reached to an end point
                if (point.X == end.X && point.Y == end.Y)
                {
                    return currNode.Distance;
                }
                queue.Dequeue();

                // Checking four directions i.e up, down, left, right. No diagonal
                for (int i = 0; i < 4; i++)
                {
                    int x = point.X + RowNumber[i];
                    int y = point.Y + ColNumber[i];

                    //if adjacent cell is valid, has path and not visited then enqueue it.
                    if (IsValidCell(p, q, x, y) && inputMatrix[x, y] == 1 && !visitedCell[x, y])
                    {
                        visitedCell[x, y] = true;
                        CoOrdinate adjPoint;
                        adjPoint.X = x;
                        adjPoint.Y = y;
                        Cell adjacentCell;
                        adjacentCell.Distance = currNode.Distance + 1;
                        adjacentCell.Point = adjPoint;
                        queue.Enqueue(adjacentCell);
                    }
                }
            }
            return -1;
        }

        // Checking for valid cell
        public static bool IsValidCell(int p, int q, int x, int y)
        {
            return (x >= 0 && x < p && y >= 0 && y < q);
        }
    }

    // It stores the distance from source point and co-ordinate point
    struct Cell
    {
        public int Distance;
        public CoOrdinate Point;
    }

    // Store co-ordinate points
    struct CoOrdinate
    {
        public int X;
        public int Y;
    }
}
