using System.Transactions;

namespace Demo
{
    class Program

    {
        public static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Enter the value");
            Console.WriteLine("1.table\n2.Swap\n3.Vowels count\n4.exit");
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


