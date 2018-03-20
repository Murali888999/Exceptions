using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception1
{
    class UncheckedException
    {
        public void test()
        {
            unchecked
            {
                int i = int.MaxValue;
                Console.WriteLine(i + 2);
            }
            
        }
        static void Main(string[] args)
        {
            CheckedException obj = new CheckedException();
            obj.test();
            
            Console.ReadKey();
        }
    }
}
