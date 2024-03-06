using Interface_Mobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace class_2
{
    class Mobile_data
    {
    }
    public class MyMobile : Mobile
    {
        public void Model()
        {
            Console.WriteLine("Model = Iphone");
        }
        public void Color()
        {
            Console.WriteLine("Color = Black");
        }
        public void Camera()
        {
            Console.WriteLine("Camera = 24mp");
        }
        public void Storage()
        {
            Console.WriteLine("Storage = 4-128");
        }
    }


    public class NullMobile : Mobile
    {
        public static NullMobile instance = null;
        public static NullMobile getInstance
        {
            get
            {
                if (instance == null)
                    return new NullMobile();
                return instance;

            }
        }


        public void Model() { }
        public void Color() { }
        public void Camera() { }
        public void Storage() { }

    }
}
