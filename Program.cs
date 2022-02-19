using System;
using System.IO;

namespace practical5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter w = new StreamWriter("test.txt");
            Console.WriteLine("Enter the data to write in File");
            string str = Console.ReadLine();
            w.Write(str);
            w.Close();

            StreamReader r = new StreamReader("test.txt");
            string data=r.ReadToEnd();
            Console.WriteLine($"Content present in file:\n{data}");
            r.Close();
            Console.WriteLine("Operation Completed");
            Console.ReadLine();
        }
    }
}
