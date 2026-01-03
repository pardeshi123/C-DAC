namespace _38Demo_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Predicate delegate
            Predicate<int> _Even = x => x % 2 == 0;
            Predicate<int> _Odd = x => x % 2 != 0;

            Console.WriteLine("Enter a number");
            int no = Convert.ToInt32(Console.ReadLine());

            var evenResult = _Even(no);
            var oddResult = _Odd(no);
            Console.WriteLine($"For Nunmber = {no} --> Even: {evenResult}, Odd: {oddResult}");
            #endregion

            #region Action Delegate 

            Func<int> func1 = delegate ()
                                {
                                    return 1;
                                };
            var result = func1();
            Console.WriteLine(result);

            Func<double> func3 = () => { return 23.33; };

            var result3 = func3();
            Console.WriteLine(result3);

            Func<string> func2 = delegate ()
                                {
                                    return "Hugh Jackman";
                                };
            var result2 = func2();
            Console.WriteLine(result2);

            #endregion

            #region TResult Func<in T, out TResult>(T arg)


            Func<int, Boolean> del3 = new Func<int, bool>(check);
            #endregion
        }
        public static Boolean check(int x)
        {
            return x % 2 == 0;
        }
    }


 
}
