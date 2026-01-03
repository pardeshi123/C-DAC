namespace PersonClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            employee emp = new employee();
            emp.Employeedata("Siddharth", "Pardeshi");
        }
    }

    public class employee
    {
        public string firstname;
        public string lastname;

        public void Employeedata(string firstname, string lastname) { 
             this.firstname = firstname;
            this.lastname = lastname;

            Console.WriteLine(firstname + " " + lastname);

        }
    }
}
