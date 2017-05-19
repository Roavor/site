using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder cnStr = new SqlConnectionStringBuilder();
            cnStr.InitialCatalog = "AutoLot";
            cnStr.DataSource = @".\SQLEXPRESS";
            cnStr.IntegratedSecurity = true ;
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnStr.ConnectionString;
                cn.Open();
                string strSQL = "Select * From Inventory";
                SqlCommand myCommand = new SqlCommand(strSQL, cn);
                using (SqlDataReader myDataReadrer=myCommand.ExecuteReader())
                {
                    while (myDataReadrer.Read())
                    {
                        Console.WriteLine("-> Make: {0}, PetName: {1}, Color: {2}.",myDataReadrer["Make"].ToString(),myDataReadrer["PetName"].ToString(),myDataReadrer["Color"].ToString());
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
