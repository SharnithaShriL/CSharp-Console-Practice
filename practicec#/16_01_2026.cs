using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicec_
{
    internal class _16_01_2026
    {
        public void get_two_digit_num()
        {
            Console.WriteLine("Enter Two digit number");
            int two_di_num = int.Parse(Console.ReadLine());
            int first_num = two_di_num / 10;
            int sec_num = two_di_num % 10;
           
            int new_first_num = sec_num;
            int new_sec_num = first_num;
            
            
            int swap_two_num = (new_first_num * 10) + new_sec_num;
            if(two_di_num > swap_two_num)
            {
                Console.WriteLine($"Given number is greater then Swap number {two_di_num}");
            }
            else
            {
                Console.WriteLine($"Given number is les than swap number {swap_two_num}");
            }
        }
        ///------------------------------------------------------------
        ///remove non letter charaters
        public void remove_non_letter_chars()
        {
            Console.WriteLine("Enter sentence :");
            string str = Console.ReadLine();
            char[] char_arr = str.ToCharArray();
            char[] new_arr = new char[char_arr.Length];
            for(int i=0;i<char_arr.Length;i++)
            {
                if (char.IsDigit(char_arr[i]))
                {
                    continue;
                }
                else if (char.IsLetter(char_arr[i]))
                {
                    new_arr[i] = char_arr[i];
                }
                else
                {
                    continue;
                }
            }
            string result = new string(new_arr);
            Console.WriteLine(result);
        }
        //---------------------------------------------------
        //remove the vowles from the string
        public void remove_vowles()
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            string res = result_remove_vowles(str);
            Console.WriteLine(res);
        }
        public string  result_remove_vowles(string strr)
        {
            char[] char_arr = strr.ToCharArray();
            char[] new_arr = new char[char_arr.Length];
            if(strr != null)
            {
                for(int i=0;i<char_arr.Length;i++)
                {
                    if (char_arr[i]=='a' || char_arr[i] == 'e'||char_arr[i] == 'i'||char_arr[i] == 'o'||char_arr[i] == 'u'||char_arr[i] == 'A' || char_arr[i] == 'E' || char_arr[i] == 'I' || char_arr[i] == 'O' || char_arr[i] == 'U')
                    {
                        continue;
                    }
                    else
                    {
                        new_arr[i] = char_arr[i];
                    }
                }
            }
            string result = new string(new_arr);
            return result;
        }

    }
}
