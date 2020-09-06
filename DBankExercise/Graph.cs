using System;
using System.Collections.Generic;
using System.Text;

namespace DBankExercise
{
    class Graph
    {
        private Node topNode;
        private List<int> finalPath = new List<int>();
        public Graph() { }

        public Node TopNode
        {
            get { return topNode; }
            set { topNode = value; }
        }

        public List<int> FinalPath
        {
            get { return finalPath; }
            set { finalPath = value; }
        }

        public void solve()
        {
            List<int> currentPath = new List<int>();
            currentPath.Add(topNode.Value);
            topNode.traverse(currentPath, FinalPath);

            Console.WriteLine("Max sum: {0}", Graph.pathToValue(FinalPath));
            Console.Write("Path: ");
            Console.Write(FinalPath[0]);
            for(int i = 1; i < FinalPath.Count; i++)
            {
                Console.Write(", " + FinalPath[i]);
            }
        }

        public static int pathToValue(List<int> path)
        {
            int total = 0;
            foreach(int value in path)
            {
                total += value;
            }
            return total;
        }

    }
}
