using System;

namespace Course_end_Project_2
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
                FileHandling file = new FileHandling();
                Console.WriteLine("Select the Operation");
                Console.WriteLine("1. Retrieve the data \n 2. Update the data ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                            {
                                Console.WriteLine("Enter File Name");
                                string fileName = Console.ReadLine();

                                file.Retrieve(fileName);
                                break;
                            }

                    case 2:
                            {
                                Console.WriteLine("Enter the name of the file where you want to update the data");
                                string fileName = Console.ReadLine();
                                Console.WriteLine("Enter Teacher data \n");
                                Console.Write("ID: \t");
                                int id = int.Parse(Console.ReadLine());
                                Console.Write("Name:\t");
                                string name = Console.ReadLine();
                                Console.Write("Class:\t");
                                string Class = Console.ReadLine();
                                Console.Write("Section: ");
                                string section = Console.ReadLine();
                                file.Update(fileName, id, name, Class, section);
                                break;
                            }                                                                        
                    default:
                            {
                                Console.WriteLine("File not found");
                                break;
                            }
                      
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Oops there is some thing wrong" + ex.Message);
            }
            Console.WriteLine("Press X If You Want To Retry.");

            Console.WriteLine("Press Any Key To Exit!!!!");
            choice = Console.ReadLine();
        }
            while (choice== "x" || choice=="X");
            Console.ReadKey();


        }
    }
}
