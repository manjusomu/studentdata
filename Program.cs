
using System;
using System.IO;

class Program
{
    static void Main()
    {
     
     
            // Specify the path to your text file
            string filePath = @"C:\Users\LENOVO\Documents\new\student.txt";
          //  File.Create(filePath);
          if(File.Exists(filePath))
        {
            string[] lines= File.ReadAllLines(filePath);
            foreach(var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("invalid file path");

        }
          
    }
}