using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class ananymousDelgates
    {
        static void Main(string[] args)
        {
            mydel obj = delegate (string names)
              {
                  return "hello " + names + " i am naresh";
              };
            string str = obj("subbu! ");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
