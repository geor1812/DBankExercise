using System;
using System.Collections.Generic;
using System.Text;

namespace DBankExercise
{
    class Graph
    {
        private Node topNode;

        public Graph() {}

        public Node TopNode
        {
            get { return topNode; }
            set { topNode = value; }
        }
    }
}
