using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicec_
{
    internal class _05_01_2026
    {

        public void sum_digits()
        {
            ///Sum of Digits in Integer
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int total = 0;
            while (num > 0)
            {
                total = (num % 10) + total;
                num = num / 10;
            }
            Console.WriteLine(total);
        }
        //-------------------------------------------------//
        ///Reverse Words in Sentence
        public void reverse_sentence()
        {
            Console.WriteLine("Enter sentence : ");
            string sentence = Console.ReadLine();

            string res = reverse_res(sentence);

        }
        public string reverse_res(string sentence)
        {
            string[] words = sentence.Split(" ");
            for(int i= words.Length-1;i>=0;i--)
            {
                Console.Write(words[i]+" ");
            }
            return "success";
        }
        //---------------------------------------------------//
        /// File Size in Bytes
        public void file_size()
        {
            FileInfo ff = new FileInfo(@"C:\Users\sshri\OneDrive - DXC Production\Documents\Neptune_proj\EMV\Neptune DXC Validation Checklist v1.1 12262025.xls\");
            if(ff.Exists)
            {
                Console.WriteLine(ff.Length);
            }
            else
            {
                Console.WriteLine("no size");
            }
        }
        //----------------------------------------------------//
        /// Multiply Two Arrays
        public void multiply_array ()
        {
            int[] arr_1 = { 1, 3, -5, 4 };
            int[] arr_2 ={ 1, 4, -5, -2 };
            int[] res_array = new int[4];
           for(int i=0;i<arr_1.Length;i++)
            {
                res_array[i] = arr_1[i] * arr_2[i];
            }
           for(int i=0;i<res_array.Length;i++)
            {
                Console.Write(res_array[i]+" ");
            }

        }
        //---------------------------------------------------//
        ///Four Copies of Last Four Characters
       public void Four_Copies_of_Last_Four_Characters()
        {
            Console.WriteLine("enter sentence");
            string sen = Console.ReadLine();
            string res = res_Four_Copies_of_Last_Four_Characters(sen);
            Console.WriteLine(res);
        }
        public string res_Four_Copies_of_Last_Four_Characters(string sen)
        {
            string[] arr = sen.Split(" ");
            string copies = " ";
            for(int i=0; i<arr.Length;i++)
            {
                if(i== arr.Length-1)
                {
                    copies = $"{arr[i]}.{arr[i]}.{arr[i]}.{arr[i]}";
                }
            }
            return copies;
        }
        //-------------------------------------------//
        ///Check Multiple of 3 or 7
        public void Check_Multiple_of_3_or_7()
        {
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            if(num %3 ==0)
            {
                Console.WriteLine(true);
            }
            else if(num% 7 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        //-------------------------------------------//
        ///Extract 'PH' from String
        public void remove_ph()
        {
            Console.WriteLine("enter sentence: ");
            string sen = Console.ReadLine();
            char[] arr = sen.ToCharArray();
            string res = "";
           
                if (arr[0]=='P')
                {
                    res = res+arr[0];
                }
                if (arr[1]=='H')
                {
                    res = res + arr[1];
                }
            
            Console.Write(res);
        }

    }

}
