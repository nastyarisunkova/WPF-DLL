using System;
using System.Reflection;

namespace LAB16
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly a = Assembly.Load("Library");
            Object o = a.CreateInstance("LibraryClass");
            Type t = a.GetType("LibraryClass");

            Object[] numbers = { 5, 3 };

            MethodInfo mi = t.GetMethod("Add");
            Console.WriteLine(mi.Invoke(o, numbers));

            mi = t.GetMethod("Sub");
            Console.WriteLine(mi.Invoke(o,numbers));
        }
    }
}
