using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling2
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            NetworkLog fileHandling = new NetworkLog();
            fileHandling.ReadFile();
            Success fileHandling1 = new Success();
            fileHandling1.ReadFile();
            Failed fileHandling2 = new Failed();
            fileHandling2.ReadFile();
            Missed fileHandling3 = new Missed();
            fileHandling3.ReadFile();
            Dialled fileHandling4 = new Dialled();
            fileHandling4.ReadFile();
            Console.Read();
        }
    }
}