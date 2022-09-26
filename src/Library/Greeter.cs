using System;

namespace Library
{


    public class Greeter
    {
        private static Greeter instance = new Greeter();

        private Greeter()
        {

        }

        public static Greeter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Greeter();
                }

                return instance;
            }
        }

        public void SayHiToTheWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
