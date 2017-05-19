using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SimpleDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet carsInventoryDS = new DataSet("Car Inventory");
            carsInventoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
            carsInventoryDS.ExtendedProperties["DataSetID"] = Guid.NewGuid();
            carsInventoryDS.ExtendedProperties["Company"] = "Mikko's Hot Tub Super Store";
            Console.WriteLine();

        }
        static void FillDataSet(DataSet ds)
        {
            DataColumn carIdColumn = new DataColumn("CarId", typeof(int));
            carIdColumn.Caption = "Car ID";
            carIdColumn.ReadOnly = true;
            carIdColumn.AllowDBNull = false;
            carIdColumn.Unique = true;
            carIdColumn.AutoIncrement = true;
            carIdColumn.AutoIncrementSeed = 0;
            carIdColumn.AutoIncrementStep = 1;
            DataColumn carMakeColumn = new DataColumn("Make", typeof(string));
            DataColumn carColorColumn = new DataColumn("Calor", typeof(string));
            DataColumn carPetNameColumn = new DataColumn("PetName", typeof(string));
            carPetNameColumn.Caption = "Pet Name";
            DataTable inventoryTable = new DataTable("Inventory");
            inventoryTable.Columns.AddRange(new DataColumn[]
                { carIdColumn,carMakeColumn,carColorColumn,carPetNameColumn});
        }
    }
}
