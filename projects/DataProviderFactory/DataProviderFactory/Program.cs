using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;


namespace DataProviderFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string dp = ConfigurationManager.AppSettings["provider"];
            string cnStr = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
            DbProviderFactory df = DbProviderFactories.GetFactory(dp);
            using (DbConnection cn=df.CreateConnection())
            {
                Console.WriteLine("Your connection object is {0}",cn.GetType().Name);
                cn.ConnectionString = cnStr;
                cn.Open();
                DbCommand cmd = df.CreateCommand();
                Console.WriteLine("Your command object is {0}",cmd.GetType().Name);
                cmd.Connection = cn;
                cmd.CommandText = "Select * From Inventory";
                using (DbDataReader dr=cmd.ExecuteReader())
                {
                    Console.WriteLine("Your data reader object is {0}",dr.GetType().Name);
                    Console.WriteLine("\n**********Current Inventory*******");
                    while (dr.Read())
                    {
                        Console.WriteLine("-> Car#{0} is a {1}.",dr["CarId"],dr["Make"].ToString());
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
