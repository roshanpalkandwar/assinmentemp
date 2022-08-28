using System;

namespace empassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecom employee saraly masage");
            Console.WriteLine("choose option\n 1.check absent present\n2.emp daily wages\n3.empy part time wages\n4.switch lopp\n5.wages for month ");
            int opt = Convert.ToInt32(Console.ReadLine());



            switch (opt)
            {
                case 1:
                    emppresenty.emplyeeattendcecheck();
                    break;
                 case 2:
                    empdailywages.CalculateDilywage();
                    break;
                    case 3:
                    parttimeempwages.calculatepercentage();
                    break;
                    case 4:
                    switchloop.loopsatatment();
                    break;
                case 5: wagesForMonth.calculateEmplymMonthWages();
                    break;
                    default:
                    break;
            }
        }
    }
}