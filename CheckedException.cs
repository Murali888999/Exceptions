using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception1
{
    class CheckedException 
    {
        public void test()
        {
            //checked
            //{
            //    int i = int.MaxValue;
            //    Console.WriteLine(i + 2);
            //}
            try
            {
                int i = int.MaxValue;
                Console.WriteLine(i + 2);
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);
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
