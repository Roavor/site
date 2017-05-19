using System;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotConnetedLayer
{
    public class InventoryDAL
    {
        private SqlConnection sqlCn=null;
        public void OpenConnection(string connectionString)
        {
            sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();
        }
        public void CloseConnection()
        {
            sqlCn.Close();
        }
        public void InsertAuto(int id, string color, string make, string petName)
        {
            string sql = string.Format("Insert into inventory " + "(CarID, Make, Color, PetName) Values" + "(@CarID, @Make, @Color, @PetName)");
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@CarID";
                param.Value = id;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                 param = new SqlParameter();
                param.ParameterName = "@Make";
                param.Value = make;
                param.SqlDbType = SqlDbType.Char;
                param.Size = 10;
                cmd.Parameters.Add(param);

                 param = new SqlParameter();
                param.ParameterName = "@Color";
                param.Value = color;
                param.SqlDbType = SqlDbType.Char;
                param.Size = 10;
                cmd.Parameters.Add(param);

                 param = new SqlParameter();
                param.ParameterName = "@PetName";
                param.Value = petName;
                param.SqlDbType = SqlDbType.Char;
                param.Size = 10;
                cmd.Parameters.Add(param);
            }
        }
        public void InsertAuto(NewCar car)
        {
            string sql = string.Format("Insert into inventory " + "(CarID, Make, Color, PetName) Values" + "('{0}', '{1}', '{2}', '{3}',)", car.CarID, car.Make, car.Color, car.PetName);
            using (SqlCommand cmd=new SqlCommand(sql,this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteCar(int id)
        {
            string sql = string.Format("Delete from Inventory where CarID = '{0}'",id);
            using (SqlCommand cmd=new SqlCommand(sql,this.sqlCn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    Exception error = new Exception("Sorry thet car is on order!!!", ex);
                    throw error;
                }
            }
            
        }
        public void UpgrateCarPetName(int id,string newPetName)
        {
            string sql = string.Format("Upgrate Inventory Set PetName='{0}' Where CarID = '{1}'", newPetName, id);
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetAllInventoryAsDatatable()
        {
            DataTable inv = new DataTable();
            string sql = "SELECT * FROM Inventory";
            using (SqlCommand cmd=new SqlCommand(sql,this.sqlCn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                inv.Load(dr);
                dr.Close();
            }
            return inv;
        }
        public string LookUpPetName(int carID)
        {
            string carPetName = string.Empty;
            using (SqlCommand cmd=new SqlCommand("GetPetName",this.sqlCn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@CarID";
                param.SqlDbType = SqlDbType.Int;
                param.Value = carID;
                param.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(param);

                 param = new SqlParameter();
                param.ParameterName = "@petName";
                param.SqlDbType = SqlDbType.Char;
                param.Size = 10;
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                carPetName = (string)cmd.Parameters["@petName"].Value;
            }
            return carPetName;
        }
        public void ProcessCreditRisks(bool throwEx,int custID)
        {
            Console.WriteLine("initialisation lname and fname");
            string fName = string.Empty;
            string lName = string.Empty;
            Console.WriteLine("sql command");
            SqlCommand cmdSelect = new SqlCommand(
                string.Format("Select * From Customers where CustId={0}", custID), sqlCn);
            Console.WriteLine("Box using");
            using (SqlDataReader dr = cmdSelect.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    fName = (string)dr["FirstName"];
                    Console.WriteLine("fname = ",fName);
                    lName = (string)dr["LastName"];
                    Console.WriteLine("lname = ",lName);
                }
                else
                    return;
            }
            SqlCommand cmdRemove = new SqlCommand(
                string.Format("Delete from Customers where CustId={0}",custID),sqlCn);
            SqlCommand cmdInsert = new SqlCommand(string.Format("Insert Into CreditRisks" +
                "(CustId, FirstName, LastName) Values" +
                "({0}, '{1}','{2}')",custID,fName,lName),sqlCn);
            SqlTransaction tx = null;
            Console.WriteLine("throw exeption");
            try
            {
                tx = sqlCn.BeginTransaction();
                cmdInsert.Transaction = tx;
                cmdRemove.Transaction = tx;
                cmdInsert.ExecuteNonQuery();
                cmdRemove.ExecuteNonQuery();
                if (throwEx)
                {
                    throw new Exception("Sorry! Database error!Tx failed...");
                }
                tx.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tx.Rollback();
            }
        }
    }
    public class NewCar
    {
        public int CarID { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string PetName { get; set; }
    }
}
