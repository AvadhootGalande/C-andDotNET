using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedByZero
{
    internal class Program
    {
        static void Main()
        {

            int a = 10 / int.Parse("0");
            Console.WriteLine(a);

            //soln:
            //try
            //{
            //    int a = 10 / int.Parse("0");
            //    Console.WriteLine(a);
            //}
            //catch(Exception e)
            //{
            //    Console.Write(e.Message);
            //    Console.ReadLine();
            //}
        }
    }
}
