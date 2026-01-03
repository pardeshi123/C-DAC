using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Demo_Inheritance
{
    internal class BaseClass
    {
        public BaseClass() {
        }
        public BaseClass(int no) {

            Console.WriteLine("calling from base class");
            Console.WriteLine(no);
        }

        public void methode1() {

            Console.WriteLine("calling method1");

        }

    }

  class Driveclass : BaseClass
{
    public Driveclass() : base() {
        Console.WriteLine("in derived class default constructor");
    }

    public Driveclass(int no) : base(no) {
        Console.WriteLine("in derived class");
        Console.WriteLine(no);
    }

    public void methode2() {
        Console.WriteLine("calling method2");
    }
}



}
