using System.Security.Cryptography.X509Certificates;

namespace _47Demo_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first No : ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second No : ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                if (n2 == 0)
                {
                    throw new MyCustomException($"Second number should not be zero");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    public class MyCustomException : Exception {
        public MyCustomException(string msg)
        {
           public string MyMessage{get; set ;}
           MyMessage = msg;
        }
    }
}
