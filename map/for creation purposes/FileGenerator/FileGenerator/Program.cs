using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileGenerator
{
    class Program
    {
        public static string[] lines = 
        {
            "#", "", "add_core = ", "own = ", "controller = ", "culture = ", "religion = ",
            "hre = no", "base_tax = 1", "base_production = 1", "base_manpower = 1", "trade_goods = ",
            "is_city = yes", "discorvered_by = "
        };

        public static void CreateEmptyFile(string filename)
        {
            //File.Create(filename+".txt").Dispose();
            File.WriteAllLines(filename + ".txt", lines);
        }

        public static void RenameToFirstLine(int num)
        {
            if (File.Exists(num + " - "+".txt") && new FileInfo(num + " - "+".txt").Length != 0)
            {
                string name = File.ReadLines(num + " - "+".txt").First();
                name = name.Substring(1);
                File.Move(num + " - " + ".txt", num + " - " + name+".txt");
            }
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                CreateEmptyFile(i+" - ");
                //RenameToFirstLine(i);
            }
            Console.ReadKey();
        }
    }
}
