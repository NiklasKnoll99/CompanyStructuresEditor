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
            DbReader dbReader = new DbReader("Server=TAPPQA;Database=Training-NK-Company;Trusted_Connection=true");
            dbReader.Open();

            DataTable s = dbReader.Read("SELECT * FROM viCompany"); // TEST
            Console.Write(s.Rows[0][0]);

            dbReader.Close();

            Console.ReadKey(); // stop execution
        }
    }
}
