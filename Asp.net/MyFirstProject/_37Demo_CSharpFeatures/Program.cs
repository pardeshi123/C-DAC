using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace _37Demo_CSharpFeatures
{
    public delegate Boolean Mydelegate(int no);
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the numbr: ");
            int no = Convert.ToInt32(Console.ReadLine());
            #region Check Method 


            //var result = Check(no);
            //if (result)
            //{
            //    Console.WriteLine($"No : {no} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"No : {no} is NOT greater than 10");
            //}
            #endregion

            #region MyRegion


            //Mydelegate del = new Mydelegate(Check);
            //var result = del(no);

            //if (result)
            //{
            //    Console.WriteLine($"No : {no} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"No : {no} is NOT greater than 10");
            //}

            #endregion

            #region MyRegion
            //Mydelegate del = new Mydelegate(delegate(int no)
            //{
            //    return no > 10;
            //});

            //Mydelegate del = delegate (int no)
            //{
            //    return no > 10;
            //};


            //var result = del(no);

            ////if (result)
            //if(del(no))
            //{
            //    Console.WriteLine($"No : {no} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"No : {no} is NOT greater than 10");
            //}
            #endregion

            #region MyRegion
            //Mydelegate del = (int no) =>
            //{
            //    return no > 10;
            //};


            //if (del(no))
            //{
            //    Console.WriteLine($"No : {no} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"No : {no} is NOT greater than 10");
            //}

            //#endregion

            //#region   Predicate<T> in-built delegate
            //Predicate<int> pre = (int no) =>
            //{
            //    return no > 10;
            //};

            //if (del(no))
            //{
            //    Console.WriteLine($"No : {no} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"No : {no} is NOT greater than 10");
            //}

            #endregion
            #region In-built Sum Extension Method and normal MySum Method
            //int[] arr = new int[] { 1, 5, 2, 3 };
            //var result = arr.Sum();
            //Console.WriteLine($"Sum1 = {result}");

            //var result1 = MySum(arr);
            //Console.WriteLine($"Sum2 = {result1}");

            //string[] names = new string[] { "Hugh", "John", "Tom" };
            //var result2 = MySum(names);
            ////var result3 = names.Sum();
            //Console.WriteLine($"Sum3 = {result2}");
            #endregion

            #region In-built Sum Extension Method and normal MySum Method
            //Console.WriteLine("Enter your Email ID:");
            //string? email = Console.ReadLine();
            //if (email != null)
            //{
            //    if (email.CheckForValidEmailID())
            //        Console.WriteLine("Valid EMail id");
            //    else
            //        Console.WriteLine("Invaild email Id");
            #endregion

            #region Extension MEthods: Demo 02
            //int[] numbers = { 101, 102, 103, 104, 105 };
            //string[] days = { "Mon", "Tue", "Wed", "Sun" };

            //List<int> output1 =numbers.ConvertToList(1111);
            //foreach (var item in output1)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //List<string> output2 = days.ConvertToList(4789);
            //foreach (var item in output2)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion



            #region Itertor Demo 01 :
          
            //int[] arr = { 1, 2, 3, 4, 5 };
            //arr[5] = 6;
            //foreach (int ele in arr)
            //{
            //    Console.WriteLine(ele);
            //}
            //List<int> lstArr = new List<int>();
            //lstArr.Add(11); 
            #endregion


            #region MyRegion
            MyCustomCollection customCollection = new MyCustomCollection();
            customCollection.AddElement(10);
            customCollection.AddElement(20);
            customCollection.AddElement(30);
            var result = customCollection.GetElements;
            for(int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"{result[i]}");
            }
            foreach (var item in result)
            {

                Console.WriteLine(item);   
            }
            foreach (var item in customCollection)
            {
                Console.WriteLine(item);
            }
            #endregion
        }



        public static T MySum<T>(IEnumerable<T> arr)
        {
            dynamic sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static Boolean Check(int no)
        {
            return no > 10;
        }
    }

    public class MyCustomCollection : IEnumerable

    {
        private ArrayList arr = new ArrayList();
        public ArrayList GetElements
        {
            get
            {
                return arr;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i< arr.Count;i++)
            {
               yield return arr;
            }
        }

        internal void AddElement(int v)
        {
          arr.Add(v);
        }
    }

    public static class MyClass //: String : not allowed. sesled class
    {
        public static bool CheckForValidEmailID(this string email)
        {
            return email.Contains("@b.com");
        }

        public static List<T> convertToList<T>(IEnumerable<T> arr, int asd)
        {
            List<T> lst= new List<T>();

            foreach (var item in arr)
            {
                lst.Add(item);
                Console.WriteLine($"Added nonsennce parameter{asd}");
            }
            return lst;
        }

    }
}
