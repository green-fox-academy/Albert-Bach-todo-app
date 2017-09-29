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
            Listtask listTasks = new Listtask();

            if (args.Length == 0)
            {
                Console.WriteLine("Unsupported argument");
                Opening();
                return;
            }

            if (args[0] == "-l")
            {
                listTasks.Reader();
            }

            if (args[0] == "-a")
            {
                try
                {
                    listTasks.Adder(args[1]);
                }
                catch
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }

            if (args[0] == "-r")
            {
                listTasks.Remover(args[1]);
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
