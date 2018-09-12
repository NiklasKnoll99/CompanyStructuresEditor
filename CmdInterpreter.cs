using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStructuresEditor
{
    class CmdInterpreter
    {
        public static bool InterpreteCmd(string cmd)
        {
            if (cmd == "help")
            {
                Console.Clear();
                Console.WriteLine("read <entitytype>\t\t-> displays all entities");
                Console.WriteLine("write <entitytype> <params...>\t-> add or update entity");
                Console.WriteLine("clear\t\t\t\t-> clears console");
                Console.WriteLine();

                return true;
            }

            else if (cmd == "clear")
            {
                Console.Clear();
                return true;
            }

            else if (cmd.IndexOf("read") != -1)
            {
                // Lese Datensatz
                return true;
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Unknown command! Type help to get a list of commands!");
                Console.WriteLine();
                return false;
            }
        }
    }
}
