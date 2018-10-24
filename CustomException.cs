using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class CustomException:Exception
    {
        public CustomException(string ni) : base(ni)
        {

        }
    }
    class exceptions1
    {
        static void Main(string[] args)
        {
           
           
            Console.WriteLine("enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (age < 18 || age > 100)
                {
                    throw new CustomException("ur not aligible for ote");
                }
                else
                {
                    throw new CustomException("ur aligible for ote");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
