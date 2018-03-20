using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class A
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter two numbers");
            a = Convert.ToInt32(Console.ReadLine()); 
             b = Convert.ToInt32(Console.ReadLine());
            if(b == 0)
            {
                Console.WriteLine("b value can't be zero");
            }
            else
            {
                c = a / b;
                Console.WriteLine("quotient of c is:" + c);
            }
           
            Console.ReadKey();
        }
    }
}
