using System;

namespace empassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecom employee saraly masage");
            Console.WriteLine("choose option\n 1.check absent present\n2.emp daily wages ");
            int opt = Convert.ToInt32(Console.ReadLine());



            switch (opt)
            {
                case 1:
                    emppresenty.emplyeeattendcecheck();
                    break;
                 case 2:
                    empdailywages.CalculateDilywage();
                    break;

            }
        }
    }
}