using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practicec_
{
    internal class _06_01_2026
    {
        //Check 'w' Appears 1-3 Times
        public void check_w()
        {
            Console.WriteLine("Enter string; ");
            string sen_check = Console.ReadLine();
            string res = sentence_w_check(sen_check);
            Console.WriteLine(res);
        }
        public string sentence_w_check(string sentence_need_to_check)
        {
            string sentence = sentence_need_to_check;
            for(int i=0;i<sentence.Length;i++)
            {
                if (sentence[i] == 'w'|| sentence[i] =='W')
                {
                    return "true";
                }
            }
            return "No W or w is there in the given sentence";
        }
        //------------------------------------------------------------------------//
        //First 4 Chars Lowercase, Rest Uppercase
        public void lowercaseUppercase()
        {
            Console.WriteLine("enter word: ");
            string str = Console.ReadLine();
            string res = res_lowercaseUppercase(str);
            Console.WriteLine(res);
        }
        public string res_lowercaseUppercase(string sen)
        {
            char[] chars = sen.ToCharArray();
            string res_low = "";
            string res_up = "";
            string less_4 = "";
            for (int i = 0; i < chars.Length; i++)
            {
                if(chars.Length <4)
                {
                    return sen.ToUpper();
                }
                else if (i == 0 || i == 1 || i == 2 || i == 3 )
                {
                    res_low = res_low + chars[i];
                }
                else
                {
                    res_up = res_up + chars[i];
                }
            }
            return res_low.ToLower() + res_up.ToUpper();
        }


        //------------------------------------------------------------------------//
        //Count Specific Number in Array
        public void count_number_in_array()
        {
            Console.WriteLine("enter number need to check in array : ");
            int num = int.Parse(Console.ReadLine());
            //int res = res_count_number_in_array(num);
            bool res = res_count_specific_num(num);
            Console.WriteLine(res);
        }
        public int res_count_number_in_array(int num)
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == num)
                {
                    count = count + 1;
                }
            }
            return count;
        }
        
        //Count a specified number in a given array of integers
        public bool res_count_specific_num(int num)
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            
            if(num == arr[0] || num == arr[arr.Length-1])
            {
                return true;

            }
            return false;
        }
        //------------------------------------------------------------------------//
        //Sum of Array Elements
        public void add_arrray_elements()
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                sum = sum + arr[i];

            }
            Console.WriteLine(sum);
        }
        //------------------------------------------------------------------------//
        // First and Last Element Equal in Array
        public void first_last_elemnt()
        {
            int[] arr = { 0, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            if (arr[0] == arr[arr.Length-1])
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        //------------------------------------------------------------------------//
        //First or Last Element Equal in Two Arrays
        public void First_or_Last_Element_Equal_in_Two_Arrays()
        {
            int[] arr1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            int[] arr2 = { 0, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};
            if (arr1[0] == arr2[0])
            {
                Console.WriteLine(true);
            }
            else if(arr1[arr1.Length-1]== arr2[arr2.Length-1])
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        //------------------------------------------------------------------------//
        //Rotate an array of integers in left direction
       public void rotate_array()
        {
            int[] arr = new int[3];
            Console.WriteLine("Enter array numbers");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            }
            int temp = arr[0];
            for(int i=0;i<arr.Length-1;i++)
            {
                arr[i] = arr[i+1];
            }
            arr[arr.Length - 1] = temp;
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //------------------------------------------------------------------------//
        //Max of First and Last in Array
        public void first_last()
        {
            int[] arr = new int[5];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine($"enter {i+1} number: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int h_val = arr[0];
            int l_val = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]>h_val)
                {
                    h_val = arr[i];
                }
                if (arr[i]<l_val)
                {
                    l_val = arr[i];
                }
            }
            Console.WriteLine($"Max is : {h_val} and Min is : {l_val}");
        }

        //------------------------------------------------------------------------//
        //Middle Elements of Three Arrays
        public void middle_element()
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine($"enter array1 of {i+1} num:");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"enter array2 of {i + 1} num:");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int middle_val1 = arr1.Length / 2;
            int middle_val2 = arr2.Length / 2;

            int[] arr_res = { arr1[middle_val1], arr2[middle_val2] };
            Console.Write("[");
            foreach (int result in arr_res)
            {
                Console.Write($"{result}");
            }
            Console.Write("]");

        }
        //------------------------------------------------------------------------//
        //Check Palindrome String
        public void palindrome()
        {
            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();
            char[] chars_original = word.ToCharArray();
            char[] chars_reverse = word.ToCharArray().Reverse().ToArray();
            if(chars_original.SequenceEqual(chars_reverse))
            {
                Console.WriteLine("it is plaindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }


    }
}
