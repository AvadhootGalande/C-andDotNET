using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedByZero
{
    internal class Program1
    {
        public static void exceptionZero(int val)
        {
            Console.WriteLine(val);
            exceptionZero(++val);
        }
        private static void Main()
        {

            exceptionZero(0);

            //sol:
            //try
            //{
            //    exceptionZero(0);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

        }
    }
}
