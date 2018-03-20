using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class E
    {
        static void Main(string[] args)
        {
            string s = null;
            int i = s.Length;
            Console.WriteLine(i);
            Console.Read();

        }
    }
}
