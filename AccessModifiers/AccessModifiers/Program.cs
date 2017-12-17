using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Hi();
            Blah.BlahClass();
            Console.WriteLine(Blah.AddTwoNumber(2,4));
            Blah2 b = new Blah2();
            b.BlahClass2();
            Blah2 b2 = new Blah2();
            Console.ReadKey();
        }
        public void Hi()
        {
            Console.WriteLine("Method inside program class, called inside static method");
        }
    }
    class Blah
    {
        public static void BlahClass()
        {
            Console.WriteLine("hello static. Class \"Blah\" static method");
        }
        /// <summary>
        /// Adds two numbers together
        /// </summary>
        /// <param name="firstNum">First number to add</param>
        /// <param name="secondNum">Second number to add</param>
        /// <returns></returns>
        public static int AddTwoNumber(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
    class Blah2
    {
        /// <summary>
        /// This is a method that doesn't take any arguments
        /// </summary>
        public void BlahClass2()
        {
            Console.WriteLine("hello public");
        }
    }
}
