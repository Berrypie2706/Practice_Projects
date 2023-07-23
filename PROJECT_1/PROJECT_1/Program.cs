using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                try
                {
                    string Path = "D:\\";
                    Console.WriteLine("Enter file name to read out from");
                    string fName = Console.ReadLine();
                    string fPath = Path + "/" + fName;
                    if (File.Exists(fPath))
                    {
                        string[] lines = File.ReadAllLines(fPath);
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    else
                    {
                        Console.WriteLine("File not exist");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error!!!" + ex.Message);
                }

                finally
                {
                    Console.ReadKey();
                }
                Console.WriteLine("Press X If You Want To Retry.");

                Console.WriteLine("Press Any Key To Exit!!!!");
                choice = Console.ReadLine();
            }
            while (choice == "x" || choice == "X");
        }
    }
}
