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
                Console.WriteLine(companies[i].Id);
                Console.WriteLine(companies[i].CompanyName);
                Console.WriteLine(companies[i].CountryCode);
                Console.WriteLine(companies[i].ProvinceName);
                Console.WriteLine(companies[i].PostCode);
                Console.WriteLine(companies[i].CityName);
                Console.WriteLine(companies[i].Street);
                Console.WriteLine(companies[i].HouseNumber);
                Console.WriteLine();
            }
        }
    }
}
