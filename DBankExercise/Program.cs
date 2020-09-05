using System;
using System.IO;

namespace DBankExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            readFromFile();
        }

        public static void readFromFile()
        {
            //Changing the working directory from default to the location of input.txt
            Directory.SetCurrentDirectory(@"..\..\..");
            
            //Reading the input and spliting into usable values
            string[] lines = File.ReadAllLines(@"input.txt");
            foreach(string line in lines)
            {
                string[] values = line.Split(' ');
            }
        }
    }
}
