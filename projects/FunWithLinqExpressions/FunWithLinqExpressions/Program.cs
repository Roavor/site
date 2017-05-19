using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions
{
    class ProductInfo
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public int NumberInStock  { get; set; }
        public override string ToString()
        {
            return string.Format("Name={0}, Descriptions= {1},Number of stock = {0}", Name, Descriptions, NumberInStock);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductInfo[] itemsInStock = new[]
            { new ProductInfo {Name="Mac coffe",Descriptions="Coffe with TEETH",NumberInStock=24 },
            new ProductInfo { Name = "Mac coffe", Descriptions = "Coffe with TEETH", NumberInStock = 24 },
            new ProductInfo { Name = "Mac coffe", Descriptions = "Coffe with TEETH", NumberInStock = 24 },
            new ProductInfo { Name = "Mac coffe", Descriptions = "Coffe with TEETH", NumberInStock = 24 },
            new ProductInfo { Name = "Mac coffe", Descriptions = "Coffe with TEETH", NumberInStock = 24 },
            new ProductInfo { Name = "Mac coffe", Descriptions = "Coffe with TEETH", NumberInStock = 24 },
            };
        }
                
            
        
        }
    }

