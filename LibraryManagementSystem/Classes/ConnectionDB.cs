using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    public class ConnectionDB
    {
        static string con = "Data Source=DataSourceName;Initial Catalog=DatabaseName;Integrated Security=True";
        SqlConnection deneme = new SqlConnection(con);
    }
}
