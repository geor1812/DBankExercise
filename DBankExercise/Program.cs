using System.IO;

namespace DBankExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Changing the working directory from default to the location of the input files
            Directory.SetCurrentDirectory(@"..\..\..\Input");

            Graph graph = new Graph();
            graph.readFromFile("input.txt");
            graph.solve();
        }

        
    }
}
