using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace CompanyStructuresEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            while (true)
            {
                Console.Write("Command: ");
                command = Console.ReadLine();

                CmdInterpreter.InterpreteCmd(command);
            }
        }
    }
}
