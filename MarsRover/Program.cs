using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string currDir = Environment.CurrentDirectory;
                var inputFile = File.ReadAllLines(currDir + "\\input.txt");
                var inputList = new List<string>(inputFile);
                var outputFile = new StreamWriter(currDir + "\\output.txt");

                Plateau plateau = new Plateau();
                plateau.xMin = 0;
                plateau.yMin = 0;
                plateau.xMax = int.Parse(inputList[0][0].ToString());
                plateau.yMax = int.Parse(inputList[0][2].ToString());

                for (int i = 1; i < inputList.Capacity; i=i+2)
                {
                    Rover rover = new Rover();
                    rover.x = int.Parse(inputList[i][0].ToString());
                    rover.y = int.Parse(inputList[i][2].ToString());
                    rover.direction = inputList[i][4].ToString();
                    rover.Move(inputList[i+1].ToString(), plateau);
                    outputFile.WriteLine(rover.x + " " + rover.y + " " + rover.direction);
                }
                outputFile.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                
            }
        }
    }
}
