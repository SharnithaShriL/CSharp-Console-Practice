using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicec_
{
    internal class _07_01_2026
    {
        public void find_odd_number()
        {
            int[] arr_num = new int[5];
            for(int i=0;i<arr_num.Length;i++)
            {
                Console.WriteLine($"Enter {i + 1} number: ");
                arr_num[i] = int.Parse(Console.ReadLine());
            }
            int[] reult = res_find_odd_number(arr_num);
            Console.Write("[");
            foreach(int a in reult)
            {
                Console.Write(a);
            }
            Console.Write("]");
        }
        public int[] res_find_odd_number(int[] arr_num)
        {
            int[] odd_numbers = new int[arr_num.Length];
            int index = 0;
            

            for(int i=0;i<arr_num.Length;i++)
            {
                if (arr_num[i] %2 !=0)
                {
                    odd_numbers[index] = arr_num[i];
                    index++;
                }
            }
            Array.Resize(ref odd_numbers, index);
            return odd_numbers;
        }
        //-----------------------------------------------------------------
        //Complete Missing Numbers in Range
        public void missing_element()
        {
            int[] arr_num = { 1, 3, 4, 7, 9 };
            int[] result = res_missing_element(arr_num);
            foreach(int a in result)
            {
                Console.WriteLine(a);
            }
        }
        public int[] res_missing_element(int[] arr_um)
        {
            int h_val = arr_um[0];
            int l_val = arr_um[0];
            int[] res_arr = new int[arr_um.Length];
            int index = 0;
            for(int i=0;i<arr_um.Length;i++)
            {
                if (arr_um[i]>h_val )
                {
                    h_val = arr_um[i];
                }
            }
            for (int i = 0; i < arr_um.Length; i++)
            {
                if (arr_um[i] < l_val )
                {
                    l_val = arr_um[i];
                }
            }
            for(int i=l_val;i<=h_val;i++)
            {
                bool found = false;
                for(int j=0;j<arr_um.Length;j++)
                {
                    if (arr_um[j] ==i )
                    {
                        found = true;
                        break;
                    }
                }
                if(!found)
                {
                    res_arr[index] = i;
                    index++;
                }
            }
            Array.Resize(ref res_arr, index);
            return res_arr;
        }
        //------------------------------------------------------------------
        //Check Strictly Increasing Sequence
        public void strictly_increasing()
        {
            //int[] arr = { 1, 2, 2, 3 };
            //int[] arr = { 1, 3, 1, 3 };
            int[] arr = { 1 };
            //int[] arr = { 0, 3, 1, 0 };

            int index = 0;
            int yes = 0;
            int no = 0;
            if (arr.Length <= 1)
            {
                Console.WriteLine(true);
                return;
            }
            for (int i=1;i<arr.Length;i++)
            {
                
               if (arr[index] < arr[i])
                {
                    index++;
                    yes = yes + 1;
                }
                else
                {
                    Console.WriteLine(false);
                    return;
                }
            }
            if(yes !=0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine("nothing");
            }
        }
    }
}
