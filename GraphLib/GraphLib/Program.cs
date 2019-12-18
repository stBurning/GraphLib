using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLib {

    internal class Program {
        public static Graph CreateGraph(int n) {
            List<Vertex> Vertices = new List<Vertex>();
            List<WeightedEdge> Edges = new List<WeightedEdge>();
            Random random = new Random();
            for (int i = 0; i < n; i++) {
                Vertices.Add(new Vertex<int>(i));
            }
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Edges.Add(new WeightedEdge(Vertices[i], Vertices[j], Math.Round(random.NextDouble(), 3)));
                }
            }
            return new Graph(Vertices, Edges);
        }

        public static void Main(string[] args){


            
            //Console.WriteLine(graph.ToString());
            //List<Vertex> way = graph.GetLowestWay(2, 0);
            //if (way.Count == 0) Console.Write("Нет необходимого пути ");
            //for(int i = 0; i < way.Count; i++){
              //  Console.Write(way[i]);
               // if (i != way.Count - 1) Console.Write("->");
            //}
            for(int i = 100; i < 2000; i += 100) {
                Graph graph = CreateGraph(i);
                System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
                timer.Start();
                graph.GetLowestWay(i-1, 0);
                timer.Stop();
                TimeSpan ts = timer.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine("Count of vertices: "+ i + ": "+"Time:" + elapsedTime);
            }

            Console.ReadKey();
        }
    }
}