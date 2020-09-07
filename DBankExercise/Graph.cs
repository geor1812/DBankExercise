using System;
using System.Collections.Generic;
using System.IO;

namespace DBankExercise
{
    public class Graph
    {
        private Node topNode;
        private List<int> finalPath = new List<int>();
        public Graph() { }

        //Getters and setters
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

        /**
         * Reads all graph information from file
         * The input is split into individual values used for node creation
         * Two lists are used for keeping track of the nodes on the currrent line of input and the previous line
         * Parent nodes are updated as child nodes are being read
         **/
        public void readFromFile(String fileName)
        {
           

            List<Node> parentList = new List<Node>();
            List<Node> childList = new List<Node>();

            //Reading input as strings and splitting them into individual values
            string[] lines = File.ReadAllLines(@fileName);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(' ');
                for (int j = 0; j < values.Length; j++)
                {
                    //Creating the current node and adding it to the child list
                    Node currentNode = new Node(Convert.ToInt32(values[j]));
                    childList.Add(currentNode);

                    if (i == 0)
                    {
                        //Setting the top node of the graph
                        TopNode = currentNode;
                    }
                    else
                    {
                        //Adding the current node as a child
                        if (j < parentList.Count)
                        {
                            parentList[j].Child1 = currentNode;
                        }
                        if (j > 0)
                        {
                            parentList[j - 1].Child2 = currentNode;
                        }

                    }
                }

                //The child list becomes the parent list
                parentList.Clear();
                parentList.AddRange(childList);

                childList.Clear();
            }
        }

        /**
         *  Initiates the graph traversal during which the final path is determined
         *  Prints the required information
         **/
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

        /**
         * Static method which calculates the sum of the elements of a path 
         **/
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
