namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
         
            string input = Console.ReadLine();
            int n = int.Parse(input);
            Console.WriteLine(n);

            if (n % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
