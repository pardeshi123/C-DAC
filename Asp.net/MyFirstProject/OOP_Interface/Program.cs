namespace OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implict implementation
            Console.WriteLine("Implict implementation");

            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    IDrink coldDrink = new ColdDrink();
                    coldDrink.getDrink();
                    break;
                case 2:
                    IDrink hotDrink = new HotDrink();
                    hotDrink.getDrink();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            #endregion
        }

        public interface IDrink
        {
            void getDrink();
        }

        public class HotDrink : IDrink
        {
            public void getDrink()
            {
                Console.WriteLine("Enjoy hot drink");
            }
        }
        public class ColdDrink : IDrink
        {
            public void getDrink()
            {
                Console.WriteLine("Enjoy cold drink");
            }
        }

        //public interface IDrink
        //{
        //    void getDrink();

        //}
        //public class Drink : IDrink
        //{
        //    public void getDrink()
        //    {
        //        Console.WriteLine("Enjoy drink");
        //    }
        //}
    }
}
