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
        public List<Model.Company> GetCompanies()
        {
            DbReader reader = new DbReader("Server=TAPPQA;Database=Training-NK-Company;Trusted_Connection=true");
            reader.Open();

            List<Model.Company> companies = new List<Model.Company>();

            DataTable table = reader.Read("SELECT Id, CompanyName FROM Company");

            reader.Close();

            if (table != null)
            {
                for (short i = 0; i < table.Rows.Count; i++)
                {
                    Model.Company company = new Model.Company();
                    company.Id = (int)table.Rows[i][0];
                    company.CompanyName = (string)table.Rows[i][1];

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

            DataTable table = reader.Read("SELECT Id, CompanyName FROM Company WHERE Id = " + CompanyId.ToString());

            reader.Close();

            if (table != null)
            {
                Model.Company company = new Model.Company();
                company.Id = (int)table.Rows[0][0];
                company.CompanyName = (string)table.Rows[0][1];

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
