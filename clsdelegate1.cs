using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void myDelegate(string a);//creation
    class clsdelegate1
    {
        static void display(string s)
        {
            Console.WriteLine( s);
        }
        
        static void Main(string[] args)
        {
            myDelegate obj = new myDelegate(display);//instanciation
            obj("well come to biz runtime");//invoking
        }
    }
}
/*
 well come to biz runtime
Press any key to continue . . .

    ===========================================
    delegate return type and signature same same as methd


*/