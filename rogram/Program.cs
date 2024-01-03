using System;
using System.IO;

namespace StudentDataFile
{
    internal class Program
    {
        private static void WriteStudentDataToFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (StreamWriter writing = new StreamWriter(fs))
            {
                try
                {
                    writing.WriteLine("Student Details :");
                    writing.WriteLine("Student Name : Shreya");
                    writing.WriteLine("Student Id : 036");
                    writing.WriteLine("Student courses :  .Net framework,MSSQL");
                    writing.WriteLine("Student grade : A  ");
                    writing.WriteLine("Student marks :  95/100,98/100");
                    writing.WriteLine("Student City : Karimnagar");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error writing to file: {ex.Message}");
                }
            }
        }

        private static void ReadAndDisplayStudentDataFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    using (FileStream ds = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    using (StreamReader reading = new StreamReader(ds))
                    {
                        string readme = reading.ReadToEnd();
                        Console.WriteLine(readme);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading from file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist at the given location");
            }
        }

        private static void Main()
        {
            string filePath = @"C:\problem statements\project 2\studentsdata.txt";


            WriteStudentDataToFile(filePath);
            ReadAndDisplayStudentDataFromFile(filePath);

            Console.Read();
        }
    }
}