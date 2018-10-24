using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class clsDelegates2
    {

        public void display(string naresh)
        {
            Console.WriteLine(naresh);
        }
    }
    public delegate void MyDelegate(string ss);
    class clsdelegate2
    {
        static void Main(string[] args)
        {
            clsDelegates2 obj = new clsDelegates2();
            MyDelegate objd = new MyDelegate(obj.display);
            objd("my name is naresh reddy i came from hindupur belangs to AP");
        }
    }
}
