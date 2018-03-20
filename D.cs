using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class D
    {
        static void Main(string[] args)
        {
            String s = null;
            int i=s.Length;
            Console.WriteLine(i);
            Console.Read();
       }
    }
}
