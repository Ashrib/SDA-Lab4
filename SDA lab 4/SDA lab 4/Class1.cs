using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_1
{
    class singleTon
    {
        public static int counter = 0;
        public static singleTon instance = null;
        public static singleTon getInstance
        {
            get
            {
                if(instance == null)
                    instance = new singleTon();
                return instance;
                
            }
        }

        private singleTon()
        {
            counter++;
            Console.Write("Counter:",counter);

        }

        public void PrintFun(string name)
        {
            Console.Write(name);

        }
    }
}
