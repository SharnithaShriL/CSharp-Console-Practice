using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicec_
{
    internal class _13_01_2026
    {
        //--------------------------------------------
        //Multiply Array Elements by Length
        public void mul_arr()
        {
            int[] arr = new int[5];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine($"Enter {i + 1} num:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] result = res(arr);
            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        public int[] res(int[] arr)
        {
            int len = arr.Length;
            int[] final_res = new int[arr.Length];
            for(int i=0;i<arr.Length;i++)
            {
                final_res[i] = arr[i] * len;
            }
            return final_res;
        }
        //-----------------------------------------------------------
        //Min Value from Two String Numbers
        public void fin_min_val()
        {
            string[] arr = new string[2];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine($"enter {i+1} string");
                arr[i] = Console.ReadLine();
            }
            int res = res_fin_min(arr);
            Console.WriteLine(res);
        }
        public int res_fin_min(string[] stt)
        {
            int[] new_arr = new int[2];
            for(int i=0;i<stt.Length;i++)
            {
                new_arr[i] = int.Parse(stt[i]);
            }
            if (new_arr[0]< new_arr[1])
            {
                return new_arr[0];
            }
            return new_arr[1];

        }
        //-----------------------------------------------------------
        //Coded String Conversion
        public void code_string_val()
        {
            Console.WriteLine("enter string:");
            string str = Console.ReadLine();
            string res = res_code_string_val(str);
            Console.WriteLine(res);

        }
        public string res_code_string_val(string ss)
        {
            char[] arr = ss.ToCharArray();
            for(int i=0; i<arr.Length;i++)
            {
                if (arr[i] == 'P')
                {
                    arr[i] = '9';
                }
                else if (arr[i]== 'T')
                {
                    arr[i] = '0';
                }
                else if (arr[i] == 'S')
                {
                    arr[i] = '1';
                }
                else if (arr[i] == 'H')
                {
                    arr[i] = '6';
                }
                else if (arr[i] == 'A')
                {
                    arr[i] = '8';
                }
                else
                {
                    arr[i] = arr[i];
                }
            }
            string res = new string(arr);
            return res;
        }
        //------------------------------------
        //Count Specific Character in String
        public void count_specific()
        {
            Console.Write("enter string: ");
            string str = Console.ReadLine();

            Dictionary<char, int> res = new Dictionary<char, int>();

            foreach(char c in str)
            {
                if(res.ContainsKey(c))
                {
                    res[c]++;
                }
                else
                {
                    res[c] = 1;
                }
            }
            foreach(var item in res)
            {
                Console.WriteLine($"{item.Key} --> {item.Value}");
            }
        }
        //------------------------------------------
        // Check All Uppercase or Lowercase
        public void check_up_low()
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            if(str == str.ToLower())
            {
                Console.WriteLine(true);
            }
            else if(str == str.ToUpper())
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        //---------------------------------
        //Remove First and Last Characters
        public void remove_first_last()
        {
            Console.WriteLine("Enter word");
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            char[] res = new char[chars.Length];
            
            for(int i=0;i<chars.Length;i++)
            {
                if (i == 0 )
                {
                    continue;
                }
                if(i == chars.Length-1)
                {
                    continue;
                }
                res[i] = chars[i];

            }
            string finalres = new string(res);
            Console.WriteLine(finalres);
        }
    }
}
