using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string rootPath = Path.Combine(folder, "Valorant\\Saved\\Config");
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);
            foreach (string dir in dirs)
            {
                var a = Regex.Match(dir, @"(.+?)-latam").Groups[1].Value;
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
