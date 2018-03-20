using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception1
{
    class systemException
    {
        static void Main(string[] args)
        {
            systemException obj = new systemException();
            obj.test2();

        }
        public void test2()
        {           
            try
            {
                int[] k = new int[99999999999999];
               
            }
            //catch (OverflowException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
           catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
