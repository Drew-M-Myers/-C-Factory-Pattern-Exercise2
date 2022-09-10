namespace CSharpFactoryExercise2
{
    public class program
    {
        public static void Main(string[] args)
        {
            string response = "";
            bool threeOptions;
            do
            {
                Console.Clear();
                threeOptions = true;

                Console.WriteLine("What Database to do you want to use: list, sql, or mongo?");

                response = Console.ReadLine();

                if (response != "list" && response != "sql" && response != "mongo")
                {
                    threeOptions = false;
                    Console.WriteLine("Bad input. Try again");
                    Thread.Sleep(1000);
                }

            } while (!threeOptions);
            
            IDataAccess db = DataAccessFactory.GetDataAccessType(response);

            db.SaveData();
            var products = db.LoadData();
         
            foreach (var item in products)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Name: {item.Name} --- Price: {item.Price}");
                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}