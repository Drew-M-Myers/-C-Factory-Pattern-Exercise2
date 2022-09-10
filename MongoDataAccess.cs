using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess() { }
        public static List<Product> products = new List<Product>()
        {
            new Product(){Name = "Tires", Price = 899},
            new Product(){Name = "Oil Change", Price = 100},
            new Product(){Name = "Brakes", Price = 859},
            new Product(){Name = "Rotars", Price = 600},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Data Access database.");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to Mongo Data Access database.");
        }
    }
}
