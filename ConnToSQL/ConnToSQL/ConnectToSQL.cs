using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnToSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = IPS-SQL1\ECLIPSE; Initial Catalog = M1_IP; User ID = sa; Password = 3c1tT; ApplicationIntent=ReadOnly");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT lmeEmployeeID, lmeEmployeeName FROM Employees",conn);
            SqlDataReader reader = cmd.ExecuteReader(); 
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0), reader.GetString(1));
            }
            reader.Close();
            conn.Close();

            if(Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }
    }
}
