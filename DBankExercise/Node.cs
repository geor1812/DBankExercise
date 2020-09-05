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
    }
}
