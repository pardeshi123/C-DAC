using System.Collections.Generic;

namespace _9DemoOOPInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Db choice. 1. SqlServer, 2. MySql Server, 3. Oracle Server");
            string ch= Console.ReadLine();
            int choice= Convert.ToInt32(ch);

            DataBaseFactory factory= new DataBaseFactory();
            IDatabase obj = factory.GetSomeDatabase(choice);

            Console.WriteLine("Enter db operation choice : 1. Insert, 2. Update, 3. Delete");
            int opChoice = Convert.ToInt32(Console.ReadLine());
            switch (opChoice)
            {
                case 1:
                    {
                        obj.Insert();
                        break;

                    }
                    case 2:
                    {
                        obj.Update();
                        break;
                    }
                    case 3:
                    {
                        obj.Delete(); 
                        break;
                    }
                default:
                    break;
            }

        }
    }

    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }
    public class DataBaseFactory
    {
        public IDatabase GetSomeDatabase(int choice)
        {
            IDatabase db = null;
            switch (choice)
            {
                case 1:
                    {
                        db = new SqlServer();
                        break;
                    }
                    case 2:
                    {
                        db = new MySqlServer();
                        break;
                    }
                    case 3:
                    {
                        db = new OracleServer();
                        break;
                    }
                default:
                    break;
            }
            return db;

        }
    }
    public class MySqlServer : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Record Inserted in MySql Successfylly");
        }
        public void Update()
        {
            Console.WriteLine("Record Updated in MySql Successfylly");
        }
        public void Delete()
        {
            Console.WriteLine("Record Deleted from MySql Successfylly");
        }
    }
    public class SqlServer : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Record Inserted in SqlServer Successfylly");
        }
        public void Update()
        {
            Console.WriteLine("Record Updated in SqlServer Successfylly");
        }
        public void Delete()
        {
            Console.WriteLine("Record Deleted from SqlServer Successfylly");
        }
    }

    public class OracleServer : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("Record Deleted from OracleServer Successfylly");
        }

        public void Insert()
        {
            Console.WriteLine("Record Inserted from OracleServer Successfylly");
        }

        public void Update()
        {
            Console.WriteLine("Record Updated from OracleServer Successfylly");
        }
    }
}
