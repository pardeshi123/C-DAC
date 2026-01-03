using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=7; int y=3;
            int z = x + y;

            Console.WriteLine("Addition of the x and y is: "+z);

            Boolean flag = false;
            for(int i = 2; i < x / 2; i++)
            {
                if (x % i == 0)
                {
                    flag = true;
                    break;
                }
              
            }

            if (flag)
            {
                Console.WriteLine("Number is not prime");
               
            }
            else
            {
                Console.WriteLine("Number is prime");
            }
                
        }
    }
}
