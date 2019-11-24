using System;
using System.Collections.Generic;
using GraphLib;

namespace GraphLib {
    
    internal class Program {

        public static void Main(string[] args) {

            double[,] data = new double[6, 6];
            for(int i = 0; i < data.GetLength(0); i++) {
                for (int j = 0; j < data.GetLength(0); j++) {
                    data[i, j] = 0;
                }
            }
            data[1, 0] = 4;
            data[1, 2] = 7;
            data[1, 3] = 1;
            data[3, 0] = 2;
            data[1, 5] = 1;
            data[5, 0] = 1;
            data[2, 4] = 3;
            data[4, 1] = 1;
            Graph graph = new Graph(data);
            Console.WriteLine(graph.ToString());
            List<int> way = graph.GetLowestWay(2, 3);
            Console.WriteLine(way);
            foreach (int i in way) {
                Console.WriteLine(i);
            }


        }
    }
}
