
using System;
using System.IO;

class Program
{
    static void Main()
    {
     
     
            // Specify the path to your text file
            string filePath = @"C:\Users\LENOVO\Documents\new\student.txt";
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
            File.Create(filePath);

            //Console.WriteLine("invalid file path");
            Console.ReadLine();

        }
          
    }
}