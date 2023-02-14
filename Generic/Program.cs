using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Equal = calculator.AreEqual("ab", "ab");

            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            

        }
    }
}
public class calculator
{
    public static bool AreEqual<T>( T value1, T value2)
    {
        return value1.Equals(value2);
    }
   
}

