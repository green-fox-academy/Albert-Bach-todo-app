using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    public class Listtask
    {
        string path = @"Datas.txt";
        string[] content = new string[0];

        public string[] Reader()
        {
            string path = @"Datas.txt";

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
                Console.WriteLine("Unable to read the text file");
            }

            return content;
        }

        public string[] Adder(string NewTask)
        {
            try
            {
                if (NewTask.Equals(string.Empty))
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(path))
                    {
                        writer.WriteLine(NewTask);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file:Datas.txt");
            }
            return content;
        }

        public string[] Remover(string remove)
        {
          List<string> list = new List<string>(File.ReadAllLines(path));
            if (list.Count >= 2)
            {
                try
                {
                    list.RemoveAt(int.Parse(remove) - 1);
                    File.WriteAllLines(path, list);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Unable to remove: index is out of bound");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to remove: index is not a number");
                }

            }
           

            return content;
        }
       
    }
}