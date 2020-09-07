/**
 * Models a node of a pyramid graph, which has a maximum of two children
 * Each node contains a value and pointers to the child nodes
 **/

using System.Collections.Generic;

namespace DBankExercise
{
    public class Node
    {
        private int value;
        private Node child1;
        private Node child2;

        public Node(int value)
        {
            this.value = value;
        }

        //Getters and Setters
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Node Child1
        {
            get { return child1; }
            set { child1 = value; }
        }

        public Node Child2
        {
            get { return child2; }
            set { child2 = value; }
        }

        /**
         * Recursive method used for traversing all possible paths to the bottom of the graph
         * When the bottom is reached the final path is updated
         **/
        public void traverse(List<int> currentPath, List<int> finalPath)
        {
            if(child1 != null && this.Value % 2 != child1.Value % 2)
            {
                currentPath.Add(child1.Value);
                child1.traverse(currentPath, finalPath);
                currentPath.RemoveAt(currentPath.Count - 1);
            }

            if(child2 != null && this.Value % 2 != child2.Value % 2)
            {
                currentPath.Add(child2.Value);
                child2.traverse(currentPath, finalPath);
                currentPath.RemoveAt(currentPath.Count - 1);
            }

            //Bottom of the graph is reached
            if(child1 == null && child2 == null)
            {
                if(Graph.pathToValue(currentPath) > Graph.pathToValue(finalPath))
                {
                    finalPath.Clear();
                    finalPath.AddRange(currentPath);
                }
            }
        }
    }
}
