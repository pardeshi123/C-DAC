//using System.Reflection;

//namespace _29Demo_Refelction
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            String assemblyPath = @"C:\Users\IET\Desktop\Asp.net\MyFirstProject\30Demo_MyMath\bin\Debug\net8.0\30Demo_MyMath.dll";

//            Assembly asm = Assembly.LoadFrom(assemblyPath);

//            Type[] allTypes = asm.GetTypes();

//            for (int i = 0; i < allTypes.Length; i++)
//            {
//                Type type = allTypes[i];

//                Console.WriteLine(type.FullName);
//                Console.WriteLine(type.Name);
//                Console.WriteLine(type.IsAbstract.ToString());




//                MethodInfo[] methods = type.GetMethods();

//                for (int j = 0; j < methods.Length; j++)
//                {
//                    MethodInfo method = methods[j];
//                    Console.WriteLine($"MEthod Name= {method.Name},  Return Type = {method.ReturnType.ToString}");
//                }


//            }
//        }
//    }
//}

