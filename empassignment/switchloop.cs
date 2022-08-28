

namespace empassignment
{
    internal class switchloop
    {
        public static void loopsatatment()
        {
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            Console.WriteLine("random value is " + empcheck);
            switch (empcheck)
            {
                case 0:
                    Console.WriteLine("emplyee present for fulltime present ");
                    empHrs = 8;
                    break;
                case 1:
                    Console.WriteLine("employee is part time present ");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("employee absent");
                    empHrs = 0;
                    break;
            }
            int emplywage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("total wages of employee is " + emplywage);

        }
    }
}
