//Since the scope of the exercise is small, having a single unit test class is convenient

using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBankExercise;
using System.IO;
using System.Collections.Generic;

namespace DBankExerciseTests
{
    [TestClass]
    public class UnitTests
    {
        //Setting the working directory to the path of the input folder
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Directory.SetCurrentDirectory(@"..\..\..\..\DBankExercise\Input");
        }

        [TestMethod]
        public void Should_Read_Correct_Top_Node_Value()
        {
            Graph testGraph = new Graph();
            testGraph.readFromFile("test1.txt");

            Assert.AreEqual(1, testGraph.TopNode.Value);
        }

        [TestMethod]
        public void Should_Read_Correct_Children_Values()
        {
            Graph testGraph = new Graph();
            testGraph.readFromFile("test1.txt");

            Assert.AreEqual(8, testGraph.TopNode.Child1.Value);
            Assert.AreEqual(9, testGraph.TopNode.Child2.Value);
        }

        [TestMethod]
        public void Should_Return_Correct_Sum()
        {
           
            List<int> path = new List<int>();
            path.Add(10);
            path.Add(22);
            path.Add(3);
            path.Add(12);
            path.Add(100);

            Assert.AreEqual(147, Graph.pathToValue(path));
        }


    }
}
