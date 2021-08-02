using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysCalculate
{
    class Program
    {

        static void Main(string[] args)
        {
            Days();
            Console.ReadLine();
        }
        static void Days()
        {
            Console.WriteLine("Enter Date in Given Format:(YYYY/MM/DD)");
            DateTime FromDate;
            DateTime toDate;
            x:Console.WriteLine("Please Enter valid from date");
            FromDate = Convert.ToDateTime(Console.ReadLine());
            if (validFromDate(FromDate)!=true)
            {
                goto x;
            }
           
            y:Console.WriteLine("Please Enter valid to date");
            toDate = Convert.ToDateTime(Console.ReadLine());
            if (!validToDate(toDate,FromDate))
                {
                goto y;
            }
            
            TimeSpan difference = toDate - FromDate;
            int noOfDays = difference.Days;
            Console.WriteLine(noOfDays);


        }
        static bool validFromDate(DateTime from)
        {
            if (from<DateTime.Today)
            {
                return true;
            }
            return false;

        }
        static bool validToDate(DateTime to, DateTime from)
        {
            if (to>=from)
                {
                return true;
                }
            return false;

        }
    }
}
