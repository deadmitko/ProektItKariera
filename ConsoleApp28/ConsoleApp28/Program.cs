using ConsoleApp28.Controllers;
using ConsoleApp28.Display;
using System;
using System.IO;
using System.Text;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
             View test = new View();
            while (true) test.Menu();
           
            

        }
        private static string ReadLine()
        {
            Stream inputStream = Console.OpenStandardInput(500);
            byte[] bytes = new byte[500];
            int outputLength = inputStream.Read(bytes, 0, 500);
            //Console.WriteLine(outputLength);
            char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
            return new string(chars);
        }
    }
}
