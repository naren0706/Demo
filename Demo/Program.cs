using System.Transactions;

namespace Demo
{
    class Program

    {
        public static void Main(string[] args)
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

                    case 3:
                        Vowels.VowelCount();
                        break;
                    default: 
                        flag = false;
                        break;
                }
            }

            
        }
    }
}


