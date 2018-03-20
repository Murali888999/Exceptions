using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception1
{
    class mutlipletrycatch
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
            catch (OverflowException e1)
            {
                Console.WriteLine(e1.Message);
                try
                {
                    int[] a = new int[7];
                    a[8] = 34;
                }
                catch (IndexOutOfRangeException e2)
                {
                    Console.WriteLine(e2.Message);
                }
                Console.ReadKey();
            }
        }
    }
}