using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch(databaseType)
            {
                case "lsit":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mango":
                    return new MongoDataAccess();
                default:
                    return new ListDataAccess();
            }
        }
    }
}
