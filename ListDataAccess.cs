using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess() { }
        public static List<Product> products = new List<Product>()
        {
            new Product(){Name = "Ice Cream", Price = 9},
            new Product(){Name = "Milk", Price = 5},
            new Product(){Name = "Yogurt", Price = 8},
            new Product(){Name = "Cheese", Price = 10},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access database.");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to List Data Access database.");
        }
    }
}
