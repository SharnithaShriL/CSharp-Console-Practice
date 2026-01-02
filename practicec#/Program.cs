using System.ComponentModel;
using System.Drawing;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace practicec_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------30-12-2025-------------

            //Console.WriteLine("enter first number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter second number:");
            //int num2 = int.Parse(Console.ReadLine());
            //Program obj = new Program();
            //int res = obj.Adding(num1, num2);
            //Console.WriteLine(res);

            Console.WriteLine("Enter num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            int num2 = int.Parse(Console.ReadLine());
            Program obj = new Program();
            int vv = obj.findval(num1, num2);
            Console.WriteLine(vv);
        }
        public int findval(int first,int second)
        {
            int res = 0;

            if (first < second)
            {
                res = first - second;
                return Math.Abs(res);
            }
            else if (first > second)
            {
                res = 2 * (first - second);
                return Math.Abs(res);
            }
            else
            {
                return 0;
            }

        }


        public int Adding(int first, int second)
        {
            int sum = 0;
            sum = first + second;
            int product = 0;

            if (first == second)
            {
                product = sum * 3;
                return product;
            }
            else
            {
                return sum;
            }
        }
    }
}


           
            








            //Console.WriteLine("Enter string:");
            //string str = Console.ReadLine();
            //Console.WriteLine("enter char that to added in the string: ");
            //char letter = Char.Parse(Console.ReadLine());


            //Console.WriteLine("THE ANSWER IS .....");
            //Console.WriteLine(letter + str + letter);

            //--------------29-12-2025-------------
            //Console.WriteLine("Enter 1st integer");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter 2nd integer");
            //int num2 = int.Parse(Console.ReadLine());

            //if(num1>0 && num2<0)
            //{
            //    Console.WriteLine("True");
            //}
            //else if(num1<0 && num2>0)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}






            //Swap First and Last Characters
            //Console.WriteLine("enter word");
            //string word = Console.ReadLine();

            //char[] word_char = word.ToCharArray();
            //char temp = word_char[0];
            //word_char[0] = word_char[word_char.Length - 1];
            //word_char[word_char.Length - 1] = temp;

            //string res = new string(word_char);
            //Console.WriteLine(res);




            ////Remove Character by Index
            //Console.WriteLine("Enter word:");
            //string str_word = Console.ReadLine();
            //Console.WriteLine("enter what word to remove:");
            //char str_char_remove = char.Parse(Console.ReadLine());
            //if(str_word !=null)
            //{
            //    for (int i = 0; i < str_word.Length; i++)
            //    {
            //        if(str_word[i] == str_char_remove)
            //        {
            //            continue;

            //        }
            //        else
            //        {
            //            Console.Write(str_word[i]);
            //        }
            //    }
            //}




            ////Rectangle Pattern with Number
            //Console.WriteLine("Enter number: ");
            //int num = int.Parse(Console.ReadLine());
            //for(int i=0; i<num;i++)
            //{
            //    if(i==0 || i==num-1)
            //    {
            //        for(int j=0;j<=3;j++)
            //        {
            //            Console.Write(num);
            //        }

            //    }
            //    else
            //    {
            //        Console.Write($"{num} {num}");
            //    }
            //    Console.WriteLine();
            //}






            //--------------24-12-2025-------------
            //Repeat Number in Rows
            //Console.WriteLine("Enter number: ");
            //int num = int.Parse(Console.ReadLine());
            //for(int i=0;i<2;i++)
            //{
            //    for(int j=0;j<4;j++)
            //    {
            //        Console.Write(num+" ");
            //    }
            //    Console.WriteLine();
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(num);
            //    }
            //    Console.WriteLine();

            //}


            ////Print Age Message
            //Console.WriteLine("Enter your age:");
            //int age = int.Parse(Console.ReadLine());
            //if(age>20)
            //{
            //    Console.WriteLine("You look older than 20");
            //}
            //else
            //{
            //    Console.WriteLine("Younger");
            //}



            ////Specified Formula with Three Numbers

            //    Console.WriteLine($"enter 1st number : ");
            //    int x = int.Parse(Console.ReadLine());
            //Console.WriteLine($"enter 2st number : ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"enter 3st number : ");
            //int z = int.Parse(Console.ReadLine());
            //Console.WriteLine($" (x+y).z is : {(x + y) * z}");
            //Console.WriteLine($" x.y + y.z is  : {(x*y) + (y*z)}");



            ////Average of Four Numbers
            //List<int> nums = new List<int>();
            //int total_val = 0;
            //int total_count = 0;
            //float avg_val = 0;
            //for(int i=0;i<4;i++)
            //{
            //    Console.WriteLine($"Enter {i + 1} number : ");
            //    int val = int.Parse(Console.ReadLine());
            //    nums.Add(val);
            //}
            //for(int i=0;i<nums.Count;i++)
            //{
            //    total_val = total_val + nums[i];
            //}
            //for(int i=0;i<nums.Count;i++)
            //{
            //    total_count = total_count + 1;
            //}

            //avg_val = (float)total_val / total_count;
            //Console.WriteLine($" The average value is : {avg_val}");


            ////Multiplication Table
            //Console.WriteLine("Enter number:");
            //int num = int.Parse(Console.ReadLine());
            //for(int i=0;i<=10;i++)
            //{
            //    Console.WriteLine($"{num}*{i}={num * i}");
            //}




            //--------------23-12-2025-------------

            ////Multiply Three Numbers...
            //int num = 3;  
            //int mul = 1;
            //List<int> val = new List<int>();
            //for(int i=0;i<num;i++)
            //{
            //    Console.WriteLine($"Enter {i} no: ");
            //    int input = int.Parse(Console.ReadLine());
            //    val.Add(input);
            //}
            //for(int i=0;i<val.Count;i++)
            //{
            //    mul = mul * val[i];
            //}
            //Console.WriteLine("Multiplication of three no is : "+mul);


            //// Swap two numbers...
            //Console.WriteLine("enter frist no: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second no:");
            //int num2 = int.Parse(Console.ReadLine());
            //int temp = 0;
            //temp = num1;
            //num1 = num2;
            //num2 = temp;
            //Console.WriteLine("---OUTPUT---");
            //Console.WriteLine($"NUM 1 IS :{num1}");
            //Console.WriteLine($"NUM 2 IS :{num2}");


            //Console.WriteLine("This is Sharnitha...");
            //Console.WriteLine("Sum"+(1 + 2));
            //Console.WriteLine("Divide"+(10 / 5));
