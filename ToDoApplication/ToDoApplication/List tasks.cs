using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    public class List_tasks
    {
        string path = @"./Datas.txt";

        public string[] Reader()
        {
            string path = @"./Datas.txt";
            string[] content = new string[0];

            try
            {
                content = File.ReadAllLines(path);

                if (content.Length == 0)
                {
                    Console.WriteLine("No todos for today! :)");
                }

                for (int i = 0; i < content.Length; i++)
                {
                    Console.WriteLine((i + 1) + " - " + content[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file the text file");
            }

            return content;
        }
    }
}