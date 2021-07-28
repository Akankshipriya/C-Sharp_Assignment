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
            Console.WriteLine("Please Enter valid fromdate");
            FromDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Please Enter valid todate");
            toDate = Convert.ToDateTime(Console.ReadLine());
            TimeSpan difference = toDate - FromDate;
            int noOfDays = difference.Days;
            Console.WriteLine(noOfDays);


        }
    }
}
