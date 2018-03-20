using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception1
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String msg)
            : base(msg)
        {

        }
    }
    public class customException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be greaterthan 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                validate(11);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("code executed");               
            }
            Console.ReadKey();
        }
        
    }
}
