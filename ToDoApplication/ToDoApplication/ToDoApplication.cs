using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    class ToDoApplication
    {
        static void Main(string[] args)
        {
            Opening();
            List_tasks list_Tasks = new List_tasks();


            if (args[0] == "-l")
            {
                list_Tasks.Reader();
            }


            Console.ReadLine();

            if (args[0] == "-a")
            {
                try
                {
                    list_Tasks.Adder(args[1]);
                }
                catch
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }

        }

        public static void Opening()
        {
            Console.WriteLine(
                "Command Line Todo application\n" +
                "=============================\n" +
                "Command line arguments:\n" +
                " -l Lists all the tasks\n" +
                " -a Adds a new task\n" +
                " -r Removes an task\n" +
                " -c Completes an task");
        }
    }
}

