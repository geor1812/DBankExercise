using System.Collections.Generic;

namespace DBankExercise
{
    class Node
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
