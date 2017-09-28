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
            Console.ReadLine();
        }

        public static void Opening()
            {
            Console.WriteLine("Command Line Todo application\n" +
                "=============================\n" +
                "Command line arguments:\n" +
                " -l Lists all the tasks\n" +
                " -a Adds a new task\n" +
                " -r Removes an task\n" +
                " -c Completes an task");
        }
    }
}
             
