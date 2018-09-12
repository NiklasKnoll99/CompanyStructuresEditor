using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStructuresEditor.Controller
{
    class CompanyController
    {
        public static void PrintCompanies()
        {
            Repository.CompanyRepository companyRepo = new Repository.CompanyRepository();
            List<Model.Company> companies = companyRepo.GetCompanies();

            for (short i = 0; i < companies.Count; i++)
            {
                Console.WriteLine(companies[i].Id + "\t" + companies[i].CompanyName);
            }
        }
    }
}
