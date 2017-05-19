using System;

using AutoLotConnetedLayer;
using System.Configuration;
using System.Data;

namespace AutoLotCuiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string cnStr = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
            string userCommand = "";
            InventoryDAL invDAL = new InventoryDAL();
            invDAL.OpenConnection(cnStr);
            try
            {
                ShowInstructions();
                do
                {
                    Console.WriteLine("\nPlease enter your command: ");
                    userCommand = Console.ReadLine();
                    Console.WriteLine();
                    switch (userCommand.ToUpper())
                    {
                        case "I":
                            InsertNewCar(invDAL);
                            break;
                        case "U":
                            UpdateCarPetName(invDAL);
                            break;
                        case "D":
                            DeleteCar(invDAL);
                            break;
                        case "L":
                            ListInventory(invDAL);
                            break;
                        case "S":
                            ShowInstructions();
                            break;
                        case "Q":
                            exit = true;
                            break;
                        case "P":
                            LookUpPetName(invDAL);
                            break;
                        default:
                            Console.WriteLine("Bad data! Try again");
                            break;
                    }
                } while (!exit);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                invDAL.CloseConnection();
            }
        }
        private static void ShowInstructions()
        {
            Console.WriteLine("I:Inserts a new car");
            Console.WriteLine("U: Updates anexisting car.");
            Console.WriteLine("D: Deletes an existing car");
            Console.WriteLine("L:Lists current inventory");
            Console.WriteLine("S: Shows these instructions");
            Console.WriteLine("P: Looks up pet name");
            Console.WriteLine("Q: Quits program");
        }
        private static void ListInventory(InventoryDAL invDal)
        {
            DataTable dt = invDal.GetAllInventoryAsDatatable();
            DisplayTable(dt);
        }
        private static void DisplayTable(DataTable dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                Console.Write(dt.Columns[i].ColumnName + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            for (int curRow = 0; curRow <dt.Rows.Count ; curRow++)
            {
                for (int curColmn = 0; curColmn < dt.Columns.Count; curColmn++)
                {
                    Console.Write(dt.Rows[curRow][curColmn].ToString()+"\t");
                }
                Console.WriteLine();
            }
        }
        private static void DeleteCar(InventoryDAL invDAL)
        {
            Console.Write("Enter ID of CAR to delete: ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                invDAL.DeleteCar(id);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        private static void InsertNewCar(InventoryDAL invDAL)
        {
            int newCarID;
            string newCarColor, newCarMake, newCarPetName;
            Console.Write("Enter Car id:");
            newCarID = int.Parse(Console.ReadLine());
            Console.Write("Enter Car Color:");
            newCarColor =Console.ReadLine();
            Console.Write("Enter Car Make:");
            newCarMake = Console.ReadLine();
            Console.Write("Enter Car Name:");
            newCarPetName = Console.ReadLine();
            invDAL.InsertAuto(newCarID, newCarColor, newCarMake, newCarPetName);
        }
        private static void InsertNewObjCar(InventoryDAL invDAL)
        {
            int newCarID;
            string newCarColor, newCarMake, newCarPetName;
            Console.Write("Enter Car id:");
            newCarID = int.Parse(Console.ReadLine());
            Console.Write("Enter Car Color:");
            newCarColor = Console.ReadLine();
            Console.Write("Enter Car Make:");
            newCarMake = Console.ReadLine();
            Console.Write("Enter Car Name:");
            Console.Write("Enter Car Name:");
            newCarPetName = Console.ReadLine();
            NewCar c = new NewCar
            {
                CarID = newCarID,
                Color = newCarColor,
                Make = newCarMake,
                PetName = newCarPetName
            };
            invDAL.InsertAuto(c);
        }
        private static void UpdateCarPetName(InventoryDAL invDAL)
        {
            int carID;
            string newCarPetName;
            Console.Write("Enter Car ID: ");
            carID = int.Parse(Console.ReadLine());
            Console.Write("Enter new Pet name: ");
            newCarPetName = Console.ReadLine();
            invDAL.UpgrateCarPetName(carID, newCarPetName);
        }
        private static void LookUpPetName(InventoryDAL invDAL)
        {
            Console.Write("Enter ID of Car to look up: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Pet name of {0} is {1}",id,invDAL.LookUpPetName(id).TrimEnd());
        }
    }
}
