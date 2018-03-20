using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class B
    {
        static void Main(string[] args)
        {
            int i, j, k;
            Console.WriteLine("enter two numbers:");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            try
            {
                k = i / j;
                Console.WriteLine("quotient of k is:" + k);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
             catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //catch
            //{
            //    Console.WriteLine("error");
            //}
            finally
            {
                Console.WriteLine("code executed");
            }
            Console.ReadKey();
        }
    }
}
