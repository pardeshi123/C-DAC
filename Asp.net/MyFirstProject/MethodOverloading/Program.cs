using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    internal class Program
    {

        public static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public static void Add1(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public static int Add (int a, int b, int c)
        {

            return (a + b + c);
        }

        static void Main(string[] args)
        {
            Add(1, 2);
            Add1 (11, 22);
            int sum = Add(2, 3, 4);
            Console.WriteLine(sum);

        }
    }
}
