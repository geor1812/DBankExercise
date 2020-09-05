namespace DBankExercise
{
    class Node
    {
        private int value;
        private Node child1;
        private Node child2;

        public Node(int value, Node child1, Node child2)
        {
            this.value = value;
            this.child1 = child1;
            this.child2 = child2;
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
    }
}
