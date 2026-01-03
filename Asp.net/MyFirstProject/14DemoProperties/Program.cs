using System.Net;

namespace _14DemoProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            
            int eid =emp.Eid = 1;
            Console.WriteLine($"ID  = {eid} ");
            emp.EName = "Test";
            Console.WriteLine($"Output : {emp.EName}");
            emp.EAddress = "test address";
            Console.WriteLine($"Output : {emp.EAddress}");
        }
    }
    public class Employee
    {
        private int _EId;
        private string _EName;
        private string _EAddress;
        public int Eid
        {
            set { _EId = value; }
            get { return _EId; }
        }
      

        public string EAddress
        {
            set
            {
                if (value != null)
                {
                    _EAddress = value;
                }
                else
                {
                    _EName = "invalid";
                }

            }
            get { return _EAddress; }
        }
    }
}
    

