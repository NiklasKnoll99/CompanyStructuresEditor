using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace CompanyStructuresEditor
{
    class DbReader
    {
        SqlConnection connection;

        public DbReader(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public void Open()
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }

        public DataTable Read(string sql)
        {
            SqlCommand sqlCmd = new SqlCommand(sql, connection);
            DataTable table = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCmd);
            dataAdapter.Fill(table);

            return table;
        }
    }
}
