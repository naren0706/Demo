using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Vowels
    {
        public static void VowelCount()
        {
            Console.WriteLine("Enter the String");
            string a = Console.ReadLine();
            char[] input = a.ToCharArray();
            int[] frequency = new int[26];
            foreach (char item in input)
            {
                frequency[item - 'a']++;
            }
            int count = frequency[Convert.ToInt32('a' - 'a')] + frequency[Convert.ToInt32('e' - 'a')] +
                frequency[Convert.ToInt32('i' - 'a')] + frequency[Convert.ToInt32('o' - 'a')] +
                frequency[Convert.ToInt32('u' - 'a')];
            Console.WriteLine(count);


        }
    }
}
