using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class events
    {
        public void add(int a,int b)
        {
            Console.WriteLine("sum is:"+(a+b));
        }
        public void sub(int a,int b)
        {
            Console.WriteLine("substraction is:"+(a-b));
        }
        public void mul(int a,int b)
        {
            Console.WriteLine("multiplication is:"+(a*b));
        }
        public void div(int a,int b)
        {
            Console.WriteLine("division is:"+(a/b));
        }
    }
    public delegate void MyDelegate4(int k, int b);
   

    class clsEvent1
    {
        public static event MyDelegate4 Event1;
        public static event MyDelegate4 Event2;
        public static event MyDelegate4 Event3;
        public static event MyDelegate4 Event4;
        static void Main(string[] args)
        {
            events obj1 = new events();
            Event1 += new MyDelegate4(obj1.add);
            Event2 += new MyDelegate4(obj1.sub);
            Event3 += new MyDelegate4(obj1.mul);
            Event4 += new MyDelegate4(obj1.div);
            Event4(9, 5);
            Event3(4, 7);

        }
    }
}
