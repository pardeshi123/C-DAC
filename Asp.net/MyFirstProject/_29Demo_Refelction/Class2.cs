//using System.Reflection;
//using System.Reflection.Metadata;

//namespace _29Demo_Refelction
//{
//    internal class Program1
//    {
//        static void Main(string[] args)
//        {
//            String assemblyPath = @"C:\Users\IET\Desktop\Asp.net\MyFirstProject\30Demo_MyMath\bin\Debug\net8.0\30Demo_MyMath.dll";

//            Assembly asm = Assembly.LoadFrom(assemblyPath);

//            Type[] allTypes = asm.GetTypes();

//            for (int i = 0; i < allTypes.Length; i++)
//            {
//                Type type = allTypes[i];

//                string MethodeSignature = " ";

//                MethodInfo[] allMethods = type.GetMethods();


//                for (int j = 0; j < allMethods.Length; j++)
//                {
//                    MethodInfo method = allMethods[j];
//                    MethodeSignature = method.ReturnType.ToString() + " " + method.Name + "(";


//                    ParameterInfo[] AllParameters = method.GetParameters();

//                    for (int k = 0; k < AllParameters.Length; k++)
//                    {
//                        ParameterInfo parameters = AllParameters[k];
//                        MethodeSignature = MethodeSignature + parameters.ParameterType.ToString() + " " + parameters.Name + "(";

//                    }
//                    MethodeSignature = MethodeSignature.TrimEnd(',') + ")";
//                    Console.WriteLine(MethodeSignature);

//                }


//            }
//        }
//    }
//}

