using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate string mydel(string hd);
    class Lamdaexpressions
    { 
        
        static void Main(string[] args)
        {
            mydel obj1 = name =>
              {
                  return "hello " + name + " gud morning ,how ru";
  
              };
            string str= obj1("naresh");
            Console.WriteLine(str);
        }
    }
}
