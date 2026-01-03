namespace _12Sealed_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public sealed class CMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x,int y)
        {
            return (x - y);
        }
    }
    public class AdvanceMath
    {
        public virtual int Square(int x)
        {
            return x * x;
        }
    }
    public class MyMath:AdvanceMath
    {  
        public override int Square(int x)
        {
            return x*x*100;
        }
    }
    public class MyMath2:MyMath
    {
        public override int Square(int x)
        {
            return x*x*1000;
        }
    }
}
