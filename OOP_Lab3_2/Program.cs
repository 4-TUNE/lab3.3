using System;
using System.IO;
using System.Linq;

namespace OOP_Lab3_2
{
    class Program
    {
        static string fileRead = @"input.txt";

        static string fileWrite = @"output.txt";
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(fileRead);
            StreamWriter writer = new StreamWriter(fileWrite, false, System.Text.Encoding.Default);

            string read = reader.ReadToEnd();

            read = read.Replace(" ", "");
            writer.Write(read);
            writer.Close();

        }
    }
}
