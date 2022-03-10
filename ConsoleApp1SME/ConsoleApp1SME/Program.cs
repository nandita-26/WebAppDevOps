using System;
using System.IO;

namespace ConsoleApp1SME
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            DirectoryInfo n = new DirectoryInfo(path);

            FileInfo[] f = n.GetFiles("*", SearchOption.AllDirectories); //folders
           


            foreach (FileInfo i in f)
            {
                Console.WriteLine(i.Name);
            }
           
        }
    }
}
