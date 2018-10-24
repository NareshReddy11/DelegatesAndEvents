using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class genericDelegates
    {
        public static double addnum1(int k,float l,double m)
        {
            return k + l + m;
        }
        public static void addnum2(int k,float l,double m)
        {
            Console.WriteLine(k + l + m);
        }
        public static bool length(string str)
        {
            if(str.Length >5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = addnum1;
            double result = obj1(67, 55.5f, 66.5);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = addnum2;
            obj2(67, 45.5f, 34.56);

            Predicate<string> obj3 = length;
            bool str = obj3("naresh reddy");
            Console.WriteLine(str);
        }
    }
}
/*
189
147.06
True
Press any key to continue . . .
*/