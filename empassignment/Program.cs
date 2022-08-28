using System;

namespace empassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecom employee saraly masage");
            Console.WriteLine("choose option\n 1.check absent present ");
            int opt = Convert.ToInt32(Console.ReadLine());



            switch (opt)
            {
                case 1:
                    emppresenty.emplyeeattendcecheck();
                    break;

            }
        }
    }
}