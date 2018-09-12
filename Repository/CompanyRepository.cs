using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace CompanyStructuresEditor.Repository
{
    class CompanyRepository
    {
        private Model.Company CreateCompany(DataTable table, short index)
        {
            Model.Company company = new Model.Company();
            company.Id = (int)table.Rows[index][0];
            company.CompanyName = (string)table.Rows[index][1];
            company.CountryCode = (string)table.Rows[index][2];
            company.ProvinceName = (string)table.Rows[index][3];
            company.PostCode = (string)table.Rows[index][4];
            company.CityName = (string)table.Rows[index][5];
            company.Street = (string)table.Rows[index][6];
            company.HouseNumber = (short)table.Rows[index][7];

            return company;
        }

        public List<Model.Company> GetCompanies()
        {
            DbReader reader = new DbReader("Server=TAPPQA;Database=Training-NK-Company;Trusted_Connection=true");
            reader.Open();

            List<Model.Company> companies = new List<Model.Company>();

            DataTable table = reader.Read("SELECT Id, CompanyName, CountryCode, ProvinceName, PostCode, CityName, Street, HouseNumber FROM viCompany");

            reader.Close();

            if (table != null)
            {
                for (short i = 0; i < table.Rows.Count; i++)
                {
                    Model.Company company = CreateCompany(table, i);

                    companies.Add(company);
                }

                return companies;
            }

            else
                return null;
        }

        public Model.Company GetCompanyById(int CompanyId)
        {
            DbReader reader = new DbReader("Server=TAPPQA;Database=Training-NK-Company;Trusted_Connection=true");
            reader.Open();

            DataTable table = reader.Read("SELECT Id, CompanyName, CountryCode, ProvinceName, PostCode, CityName, Street, HouseNumber FROM viCompany WHERE Id = " + CompanyId.ToString());

            reader.Close();

            if (table != null)
            {
                Model.Company company = CreateCompany(table, 0);

                return company;
            }

            else
                return null;
        }

        public void CreateCompany(Model.Company company)
        {
        }

        public void UpdateCompany(Model.Company company)
        {
        }

        public void Delete(int companyId)
        {
        }
    }
}
