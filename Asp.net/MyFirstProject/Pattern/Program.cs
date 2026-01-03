namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int n = 3;
            for(int row = 0; row < n; row++)
            {
               for(int j=0;j< n - row; j++)
                {
                    
                    Console.Write(" ");
                }
               Console.Write("*");
              if(row > 0)
                {
                    for( int x = 0; x < 2*row-1;x++)
                    {

                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            for (int row = n-1; row >= 0 ; row--)
            {
                for (int j = 0; j < n - row; j++)
                {

                    Console.Write(" ");
                }
                Console.Write("*");
                if (row > 0)
                {
                    for (int x = 0; x < 2 * row - 1; x++)
                    {

                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }




    }
}
