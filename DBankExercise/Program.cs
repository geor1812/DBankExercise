using System;
using System.Collections.Generic;
using System.IO;

namespace DBankExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            readFromFile(graph);
            graph.solve();
        }

        public static void readFromFile(Graph graph)
        {
            //Changing the working directory from default to the location of input.txt
            Directory.SetCurrentDirectory(@"..\..\..");

            List<Node> parentList = new List<Node>();
            List<Node> childList = new List<Node>();
            string[] lines = File.ReadAllLines(@"input.txt");
            for(int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(' ');
                for(int j = 0; j < values.Length; j++)
                {
                    //Creating the current node and adding it to the child list
                    Node currentNode = new Node(Convert.ToInt32(values[j]));
                    childList.Add(currentNode);

                    if(i == 0)
                    {
                        //Setting the top node of the graph
                        graph.TopNode = currentNode;
                    } else
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
    }
}
