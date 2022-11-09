using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Exception_Example
{
    internal class Program
    {
        public static void Main()
        {
            IList<string> fruits = null;
            DisplayFruits(fruits);
        }

        public static void DisplayFruits(IList<string> fruits)
        {
           foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

           //soln:
           //if(fruits == null){
           //     Console.WriteLine("No Fruits");
           //     return;
           // }
           // foreach (var fruit in fruits)
           // {
           //     Console.WriteLine(fruit);
           // }
        }
    }
}
