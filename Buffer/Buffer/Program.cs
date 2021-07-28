using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffer
{
    class Program
    {
        static void Main(string[] args)
        {
            BufferData1();
            Console.ReadLine();
        }
        static void BufferData1()
        {
            Console.WriteLine("Enter the number of values you want to put");
            int noOfValues = int.Parse(Console.ReadLine());
            List<string> values = new List<string>(noOfValues);
            Console.WriteLine("Enter ? to view data Entered");
            while (true)
            {
                Console.WriteLine("Enter your value");
                string value = Console.ReadLine();
                if (value.Equals("?"))
                {
                    elements(values);
                    break;
                }
                else if (values.Count < noOfValues)
                {
                    values.Add(value);
                }
                else
                {
                    Console.WriteLine("Your Buffer is full");

                }
            }
            
        }
        static void elements(List<string>list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                Console.WriteLine("Values:-");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }

        }
    }
    
}
