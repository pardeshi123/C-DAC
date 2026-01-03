namespace ConstructorOverloading
{
    internal class Program
    {
       public Program()
        {
           
            int a = 10;
            Console.WriteLine(a);
        }
        public Program(int x)
        {
            int a = x;
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, calling constructor!");
            Program();
            Program(21);


        }
    }
}
