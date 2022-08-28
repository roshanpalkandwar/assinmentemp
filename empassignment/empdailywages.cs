using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empassignment
{
    internal class empdailywages
    {
        public static void CalculateDilywage()
        {

            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            Console.WriteLine("random genrate value " + empcheck);
            if (empcheck == 0)

            {
                Console.WriteLine("emplyee present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("employee absent");
                empHrs = 0;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("daily emp wage is  " + empWage);
        }
    }
}
