using System;
using System.IO;

namespace Course_end_Project_2
{
    public class FileHandling
    {
        public void Retrieve(string fName)
        {
           
                try
            {
                string path = "D:\\Practice Projects\\Course-end Project 2\\";
                string fPath = path + fName;
                if(File.Exists(fPath))
                {
                    string[] lines = File.ReadAllLines(fPath);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("File Not Exists");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }

        public void Update(string fName,int id, string name, string Class, string section)
        {
            try
            {
                string path = "D:\\Practice Projects\\Course-end Project 2";
                string fPath = path + fName;
                if (File.Exists(fPath))
                {
                    StreamWriter streamWriter = File.AppendText(fPath);
                    Console.WriteLine("\n");
                    streamWriter.WriteLine( id + "," + name + "," + Class + "," + section + ".");                
                    streamWriter.Dispose();
                    streamWriter.Close();
                    Console.WriteLine(" {0},{1},{2},{3}",id, name, Class, section);              
                    Console.WriteLine("Data is updated successfully");
                }
                else
                {
                    Console.WriteLine("File Not Found");
                }

            }
            catch(FormatException ex)
            {
                Console.WriteLine("Format Exception:" +ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error while updating the data :" + e.Message);
            }

        }
    }
}
