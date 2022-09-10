using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess() { }
        public static List<Product> products = new List<Product>()
        {
            new Product(){Name = "Xbox", Price = 399},
            new Product(){Name = "Play Station", Price = 399},
            new Product(){Name = "Custom PC", Price = 1000},
            new Product(){Name = "Graphics Card", Price = 425},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL Data Access.");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to SQL Data Access.");
        }
    }
}
