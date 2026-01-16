using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace practicec_
{
    internal class _14_01_2025
    {
        //---------------------------------------------------
        //Alphabetical Order of String Letters
        public void order_alphabet()
        {
            Console.WriteLine("enter string; ");
            string str = Console.ReadLine();

           string res = new string(str.OrderBy(x => x).ToArray());
            Console.WriteLine(res);

        }
        //---------------------------------------------------
        //Odd or Even Length of String
        public void check_odd_even()
        {
            Console.WriteLine("enter string:");
            string str = Console.ReadLine();

            int str_len = str.Length;
            if(str_len%2==0)
            {
                Console.WriteLine("Even length...");
            }
            else
            {
                Console.WriteLine("Odd length...");
            }
        }
        //---------------------------------------------------
        //ake a positive number and return the nth odd number
        public void n_th()
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int res = res_nth(num);
            Console.WriteLine(res);
        }
        public int res_nth(int val)
        {
            int resulat_val = 0;
            if(val >0)
            {
                resulat_val = (2 * val) - 1;
            }
            else
            {
                Console.WriteLine("Enter postive number:");
            }
            return resulat_val;
        }
        //---------------------------------------------------
        //Get ASCII Value of Character
        public void ascii_func()
        {
            Console.WriteLine("Enter character:");
            char ch = char.Parse(Console.ReadLine());
            int res = (int)ch;
            Console.WriteLine(res);
        }
        //---------------------------------------------------
        //Check Word Plural
        public void check_plural()
        {
            Console.WriteLine("Enter string: ");
            string st = Console.ReadLine();
            bool res =st.EndsWith('s');
            if(res)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine(res);
            }
        }
        //---------------------------------------------------
        // Sum of Squares in Array
        public void sum_square_array()
        {
            int[] arr = new int[4];
           
            int sum = 0;

            for (int i=0;i<arr.Length;i++)
            {
                Console.WriteLine($"Enter{i + 1} number");
                arr[i] = int.Parse(Console.ReadLine());
                sum =sum +( arr[i] * arr[i]);
            }
            Console.WriteLine("RESULT IS :"+sum);
        }
        //---------------------------------------------------
        // Integer to String and Vice Versa
        public void int_string()
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            int convert_str = int.Parse(str);
            Console.WriteLine($"int to string : {convert_str}, Type : {convert_str.GetType()}");
            string convert_int = convert_str.ToString();
            Console.WriteLine($"string to int : {convert_int}, Type : {convert_int.GetType()}");
        }

        //----------------------------------------
        //Convert Array Elements to Strings
        public void convert_arr_str()
        {
            object[] mixed_arr = new object[5];
            mixed_arr[0] = 01;
            mixed_arr[1] = "Sharnitha shri";
            mixed_arr[2] = true;
            mixed_arr[3] = 88.23;
            mixed_arr[4] = System.DateTime.Now;
            //----------------//
            for(int i=0;i<mixed_arr.Length;i++)
            {
                Console.WriteLine($"Original{mixed_arr[i]}:{mixed_arr[i].GetType()}");
            }
            Console.WriteLine("-----------------------------------------");
            for(int i=0;i<mixed_arr.Length;i++)
            {
                mixed_arr[i] = mixed_arr[i].ToString();
            }
            for (int i = 0; i < mixed_arr.Length; i++)
            {
                Console.WriteLine($"Updated String{mixed_arr[i]}:{mixed_arr[i].GetType()}");
            }


        }
    }
}
