using Proekt2.Data.Models;
using System;
using System.IO;

namespace Proekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            proektContext test = new proektContext();

            Console.WriteLine( Path.GetPathRoot("C:\\Users\\Student KK1\\Desktop\\bear_8.jpg"));
            Console.WriteLine( Path.GetFileName("C:\\Users\\Student KK1\\Desktop\\bear_8.jpg"));
            Console.WriteLine( Path.GetFullPath("C:\\Users\\Student KK1\\Desktop\\bear_8.jpg"));
            Console.WriteLine( Path.GetExtension("C:\\Users\\Student KK1\\Desktop\\bear_8.jpg"));
            Console.WriteLine( new FileInfo("C:\\Users\\Student KK1\\Desktop\\bear_8.jpg").Name);
            
        }
    }
}
