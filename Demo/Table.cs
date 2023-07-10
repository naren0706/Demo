using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Table
    {
        public static void table()
        {
            Console.WriteLine("Enter the value for the table");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(input + "*" + i + "=" + (i * input));
            }
        }
    }
}
