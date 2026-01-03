using _07Demo_Inheritance;

namespace _7Demo_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, We are lerning inheritance");

            #region Demo 00
            //BaseClass baseObj = new BaseClass();
            //baseObj.methode1();
            //Driveclass derivedObj = new Driveclass();

            //derivedObj.methode1();
            //derivedObj.methode2();
            //BaseClass obj = new Driveclass();
            //obj.methode1();
            #endregion


            //DerivedClass derivedObj = new DerivedClass(1212);

            #region Method Overloadding
            CMathAdvancedMath advMath = new CMathAdvancedMath();
            Console.WriteLine(advMath.Add(1, 2, 3, 4));
            advMath.Sub(10, 5);
            #endregion

            #region override, new , virtual

            //AdvancedMath advMath = new AdvancedMath();
            advMath.Sub(10, 5);
            advMath.Mult(10, 5);
            advMath.Add(10, 5);

            #endregion
        }
    }
}
