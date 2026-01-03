using System.Diagnostics;

namespace _01OopConcept1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch case
            //Console.WriteLine("Enter a number");
            //string s = Console.ReadLine();
            //int c = Convert.ToInt32(s);
            //Console.WriteLine(c);
            //switch (c)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("in case 1");
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("in case 2");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("please enter correct choice");
            //            break;
            //        }

            //}
            #endregion

            b obj1 = new b();
            obj1.Printing_no(5);

           Class1 obj3 = new Class1();
            obj3.SayHello();

        }

    }


    public class b {
        #region object
        public void Printing_no(int x)
        {
            Console.WriteLine(x);

        }
    }
        #endregion



 namespace _03Demo_DataTypes
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                #region Basics Of DataTypes 
                // Compile : ctr + b
                // For Commenting: ctrl + k + c OR ctr + /
                // For Un-Commenting: ctrl + k + u OR ctr + /
                // Demonstration of various data types in C#
                //int x = 42;
                //System.Int32 y = 100;
                //double d = 3.14159;
                //Console.WriteLine("X = {0}, y={1}, d ={2}",x,y,d);
                //string str = "Hello Hugh JAckman";
                //String str2 = "Hello Hugh Jackman";
                //String str3 = new string("abc");
                //char ch = 'A';
                //char[] chArr = new char[2];
                //chArr[0] = 'H';
                //chArr[1] = 'i';
                //String str4 = new string(chArr); 
                #endregion

                #region If-else
                //bool isRaining = true;
                //if (isRaining)
                //{
                //    Console.WriteLine("Take an umbrella");
                //}
                //else
                //{
                //    Console.WriteLine("No need to take an umbrella");
                //}
                #endregion

                #region for loop
                //for (int i = 0; i < 5; i++)
                //{
                //    Console.WriteLine(i);
                //}
                #endregion

                #region while
                //int x = 5;
                //while (x >0)
                //{
                //    Console.WriteLine(x);
                //    x--;
                //}
                #endregion

                #region do-while
                //int x = 5;
                //do
                //{
                //    Console.WriteLine(x);
                //    x--;
                //} while (x > 0);
                #endregion

               

                #region Boxing and Unboxing and Type-casting
                #region Boxing
                //int x = 100; // Value Type
                //string str = "Hello World"; // Reference Type
                //Object obj1 = new object(); // Reference Type
                //// Boxing: Converting Value Type to Reference Type
                //obj1 = x;
                //Console.WriteLine(obj1);
                //str = Convert.ToString(x);// Boxing
                //string str2 = x.ToString();// Boxing 
                #endregion

                #region Unboxing:
                //// Unboxing: Converting Reference Type back to Value Type
                //int y = Convert.ToInt32(obj1); // Unboxing
                //int p = Convert.ToInt32(str2); // Unboxing
                //Console.WriteLine("Y ={0}, P ={1}",y,p);
                #endregion


                #region Type-casting
                //double d = 9.18;
                //int num1 =Convert.ToInt32(d); // Implicit Type-casting 
                //double d2 = num1; // Explicit Type-casting
                //Console.WriteLine("d = {0}, num1 = {1}, d2 ={2}",d,num1,d2);

                //object obj2 = new object();
                //string str4 = "Someting";
                //obj2 = str4; // Implicit Type-casting
                //string str5 = obj2.ToString(); // Explicit Type-casting

                #endregion

                #endregion

            }
        }
    }

}







