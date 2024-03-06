using class_1;
using class_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA_lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            singleTon tan =  singleTon.getInstance;
            tan.PrintFun("print function");
            Console.ReadLine();
            singleTon tan2 = singleTon.getInstance;
            tan2.PrintFun("print function");
            Console.ReadLine();
            singleTon tan3 = singleTon.getInstance;
            tan3.PrintFun("print function");
            Console.ReadLine();



            MyMobile mob1 = new MyMobile();
            mob1.Model();
            Console.ReadLine();

        }
    }
}
