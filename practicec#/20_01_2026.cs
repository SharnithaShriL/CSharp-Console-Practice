using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace practicec_
{
    internal class _20_01_2026
    {
        public void check_lower_case_indicies()
        {
            Console.WriteLine("Enter word");
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            List<int> indicies = new List<int>();
           for(int i=1;i<chars.Length;i++)
            {
                if (char.IsLower(chars[i]))
                {
                    indicies.Add(i+1);
                }
                else if (char.IsUpper(chars[i]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
           foreach(int inde in indicies)
            {
                Console.Write(inde);
            }
             
        }
        //--------------------------------------------------
        public void cumulative_sum_array()
        {
            int[] arrr ={ 1, 3, 4, 5, 6, 7 };
            double[] arr = { 1.2, -3, 4.1, 6, -5.47 };
            double firt = arr[0];
            List<double> val = new List<double>();
            for(int i=0;i<arr.Length;i++)
            {
                if(i==0)
                {
                    val.Add(arr[i]);
                    continue;
                }
                firt = firt + arr[i];
                val.Add(firt);
            }
            foreach (double cumulative in val)
            {
                Console.Write($"{cumulative:0.##} ");
            }

        }
        //---------------------------------------------------
        //Count Letters and Digits in String
        public void count_lett_digt()
        {
            Console.WriteLine("Enter sentence:");
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            int letter_count = 0;
            int digit_count = 0;
            for(int i=0;i<chars.Length;i++)
            {
                if (chars[i] == ' ')
                {
                    continue;
                }
                else if (char.IsDigit(chars[i]))
                {
                    digit_count += 1;
                }
                else if (char.IsLetter(chars[i]))
                {
                    letter_count += 1;
                }
                else
                {
                    Console.Write("INVALID");
                }
            }
            Console.WriteLine($"Digit Count : {digit_count} and Letter Count :{letter_count} ");

        }
        ////--------------------------------------------------
        /////--- Count Positives and Negatives in Array
        public void count_postive_negative()
        {
            int[] arr = new int[8];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine($"Enter {i+1} number");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int postive_num = 0;
            int negative_num = 0;
            for (int i = 0; i<arr.Length;i++)
            {
                if (arr[i] > 0)
                {
                    postive_num += 1;
                }
                else if (arr[i] < 0)
                {
                    negative_num += 1;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            Console.WriteLine($"Postive count :{postive_num} and negative count : {negative_num}");
        }
    }
}
