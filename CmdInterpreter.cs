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
                Console.Clear();
                Console.Write("Entitytype: ");

                string tablename = Console.ReadLine();

                Console.WriteLine();

                if (tablename == "Company")
                {
                    Console.Clear();
                    Controller.CompanyController.PrintCompanies();
                    Console.WriteLine();
                    return true;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("The tablename does not exist");
                    Console.WriteLine();
                    return false;
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Unknown command! Type help to get a list of commands!");
                return false;
            }
        }
    }
}
