﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empassignment
{
    internal class parttimeempwages
    {
        public static void calculatepercentage()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(1, 3);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("employee present for full time ");

            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("employee present for half time ");

            }
            else
            {
                empHrs = 0;
                Console.WriteLine("employee absent");

            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp daily wage invluding part and full time " + empWage);


        }
    }
}
