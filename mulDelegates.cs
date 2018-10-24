using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class mulDelegates
    {
        public void add(int a,int b)
        {
            Console.WriteLine("sum is:" + (a + b));
        }
        public void sub(int a,int b)
        {
            Console.WriteLine("sub is:" + (a - b));
        }
        public void mul(int a,int b)
        {
            Console.WriteLine("mul is:" + (a * b));
        }
        public void div(int a,int b)
        {
            Console.WriteLine("division is:" + (a / b));
        }
    }
    public delegate void MyDelegate1(int a, int b);
    class clsMulDelegate3
    {
        static void Main(string[] args)
        {
            mulDelegates obj1 = new mulDelegates();
            MyDelegate1 objd = new MyDelegate1(obj1.add);

            objd += obj1.sub;
            objd += obj1.mul;
            objd += obj1.div;

            objd(8, 9);

            //objd -= obj1.div;
            //objd -= obj1.mul;
            //objd(8, 9);
        }

    }
}
