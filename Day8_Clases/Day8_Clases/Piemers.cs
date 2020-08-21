using System;
using System.Collections.Generic;
using System.Text;

namespace Day8_Clases
{
    class Piemers
    {
        public static void Test1()
        {//publisku metodi var izsaukt no cita Main
            Console.WriteLine("hello world");
            Test2();
        }
        private static void Test2()
        {//private metode ir pieejama tikai sajaa Classē un nekur citu
            Console.WriteLine("Hello world 22222");
        }
    }
}
