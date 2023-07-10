using System.Transactions;

namespace Demo
{
    class Demo

    {
        public static void Main()
        {
            bool flag = true;
            while (flag)
            {
                int input  = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Table.table();
                        break;
                    case 2:
                        Swap.swap();
                        break;
                    default: 
                        flag = false;
                        break;
                }
            }

            
        }
    }
}


