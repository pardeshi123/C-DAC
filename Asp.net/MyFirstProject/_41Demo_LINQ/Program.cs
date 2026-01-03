
namespace _41Demo_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region LINQ to int[] collection
            //int[] arr = { 1, 4, 3, 2, 5 };

            //var result = from elements in arr
            //             orderby elements descending
            //             select elements;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            List<Emp> emps = new List<Emp>()
            {
                new Emp() { Id = 11, Name = "Ganesh", Address = "Pune" },
                new Emp() { Id = 12, Name = "Suresh", Address = "Mumbai" },
                new Emp() { Id = 13, Name = "Mitesh", Address = "Pune" },
                new Emp() { Id = 14, Name = "Rupesh", Address = "Patna" },
                new Emp() { Id = 15, Name = "Jignesh", Address = "Pune" },
                new Emp() { Id = 16, Name = "Jayesh", Address = "Pune" },
                new Emp() { Id = 17, Name = "Gukesh", Address = "Mumbai" },
                new Emp() { Id = 18, Name = "Prathamesh", Address = "Puri" },
                new Emp() { Id = 19, Name = "Mukesh", Address = "Nashik" },

            }
            ;

            #region MyRegion
            //Console.WriteLine("Enter the city starting char: ");
            //string? city = Console.ReadLine().ToLower();

            //var result1 = from emp in emps
            //              where emp.Address.ToLower().StartsWith(city)
            //             select emp;

            //elist.Add(new Emp() { Id = 20, Name = "Muktesh", Address = "Nashik" });

            //foreach (var emp in result1)
            //{
            //    emp.getDetails();
            //}



            #endregion

            #region LINQ with .ToList() Extension method
            //Console.WriteLine("Enter city Start character:");
            //string? city = Console.ReadLine().ToLower();

            //var result = (from emp in emps
            //              where emp.Address.ToLower().StartsWith(city)
            //              select emp).ToList();

            //emps.Add(new Emp() { Id = 20, Name = "Rakesh", Address = "Nashik" });

            //foreach (var emp in result)
            //{
            //    emp.getDetails();
            //}
            #endregion

            #region LINQ with Tuple syntax
            //   Console.WriteLine("Enter city Start character:");
            //   string? city = Console.ReadLine().ToLower();

            //   // LINQ Query gets fired when you start using .ToList() method
            //var result = (from Emp emp in emps
            //              where emp.Address.ToLower().StartsWith(city)
            //              select (emp.Name,emp.Address)  ).ToList();

            //   foreach (var emp in result)
            //   {
            //       Console.WriteLine($"{emp.Name} {emp.Address}");
            //   }
            #endregion

            #region LINQ with Holder class 
            Console.WriteLine("Enter city Start character:");
            string? city = Console.ReadLine().ToLower();

            // LINQ Query gets fired when you start using .ToList() method
            var result = (from emp in emps
                          where emp.Address.ToLower().StartsWith(city)
                          select new Holder() { HName = emp.Name, HAddress = emp.Address }).ToList();

            foreach (var holder in result)
            {
                holder.GetDetails();
            }
            #endregion


            // Console.WriteLine("Enter city Start character:");
            // string? city = Console.ReadLine().ToLower();

            ////  LINQ Query gets fired when you start using .ToList() method
            // var result = (from emp in emps
            //               where emp.Address.ToLower().StartsWith(city)
            //               select new {id = emp.Id, add = emp.Address }).ToList();

            // foreach (var A_Type in result)
            // {
            //     Console.WriteLine($"id= {A_Type.id}, Address= {A_Type.add}");
            // }
        }


        public class Holder
        {
            public int HId { get; set; }
            public string HName { get; set; }
            public string HAddress { get; set; }
            public void GetDetails()
            {
                Console.WriteLine($"Id: {this.HId}, Name: {this.HName}, Address: {this.HAddress} ");
            }
        }
        public class Emp
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public string Address { get; set; }

            public void getDetails()
            {
                Console.WriteLine($"Id: {this.Id}, Name: {this.Name}, Address: {this.Address} ");
            }


        }


    }


}
