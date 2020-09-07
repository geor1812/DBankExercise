# Pyramid Challenge
This repository contains my solution to the coding exercise I received as part of the application process for a back-end .Net Software Engineering position.

### Implementation
This solution uses two classes: Node and Graph

#### Node
Models a node of a pyramid graph.
A Node object contains an integer value, and pointers to their two children nodes.
The class implements a recursive method which traverses all valid paths, thus allowing us to find the path with the maximum sum.

#### Graph
Models a directed pyramid graph.
A Graph object contains the top node of the pyramid, and a List which (after the graph is solved) contains the integer values of the nodes in the path with the maximum sum.
Since every node contains pointers to their children, it is only necessary to store the top node of the pyramid.
The class implements a static method used for calculating the sum of the elements of a path, and two non-static methods used for reading the input data from a file and solving the graph (finding the correct path and displaying the output data).

### Testing
Testing was conducted by using unit tests, which were fed multiple input files.

### Time Complexity Improvements
Because of the use of recursion to traverse all possible paths, this solution becomes rather inefficient when the input increases in size. Time complexity can be reduced from exponential to linear by using dynamic programming.
