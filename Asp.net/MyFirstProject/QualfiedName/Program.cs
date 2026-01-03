namespace QualfiedName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            System.Int32 x = 100;
            System.Int64 y = 2000;
            Int32 e= 100;
            Int16 f = 890;
            int g = 90;
            int h = 223;
            Console.WriteLine(x + y); 
            Console.WriteLine(e + f);

            #endregion
            MyClass obj = new MyClass();
            obj.getMsg();
        }
    }
}
