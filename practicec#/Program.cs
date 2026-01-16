using System.ComponentModel;
using System.Drawing;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace practicec_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _05_01_2026 obj = new _05_01_2026();
            //obj.sum_digits();
            //obj.reverse_sentence();
            //obj.file_size();
            //obj.multiply_array();
            //obj.Four_Copies_of_Last_Four_Characters();
            //obj.Check_Multiple_of_3_or_7();
            //obj.remove_ph();
            _06_01_2026 bb = new _06_01_2026();
            //bb.check_w();
            //bb.lowercaseUppercase();
            //bb.count_number_in_array();
            //bb.add_arrray_elements();
            //bb.first_last_elemnt();
            //bb.First_or_Last_Element_Equal_in_Two_Arrays();
            //bb.rotate_array();
            //bb.first_last();
            //bb.middle_element();
            //bb.palindrome();
            _07_01_2026 aa = new _07_01_2026();
            //aa.find_odd_number();
            //aa.missing_element();
            //aa.strictly_increasing();
            _09_01_2025 cc = new _09_01_2025();
            //cc.sum_of_mat();
            //cc.sum_all_mat();
            //cc.negative_mat();
            _13_01_2026 dd = new _13_01_2026();
            //dd.mul_arr();
            //dd.fin_min_val();
            //dd.code_string_val();
            //dd.count_specific();
            //dd.check_up_low();
            //dd.remove_first_last();
            _14_01_2025 ee = new _14_01_2025();
            //ee.order_alphabet();
            //ee.check_odd_even();
            //ee.n_th();
            //ee.ascii_func();
            //ee.check_plural();
            //ee.sum_square_array();
            //ee.int_string();
            // ee.convert_arr_str();
            _16_01_2026 ff = new _16_01_2026();
            //ff.get_two_digit_num();
            //ff.remove_non_letter_chars();
            ff.remove_vowles();

        }
    }
}
            //--------------30-12-2025-------------

            //Console.WriteLine("enter first number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter second number:");
            //int num2 = int.Parse(Console.ReadLine());
            //Program obj = new Program();
            //int res = obj.Adding(num1, num2);
            //Console.WriteLine(res);

            //    Console.WriteLine("Enter num1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter num2: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Program obj = new Program();
            //int vv = obj.findval(num1, num2);
            //Console.WriteLine(vv);


            //--------------02-01-2026-------------
            //Console.WriteLine("Enter number: ");
            //int num = int.Parse(Console.ReadLine());

            //if(num <200)
            //{
            //    Console.WriteLine(false);
            //}
            //else
            //{
            //    Console.WriteLine(true);
            //}

            //lower_case_string
            //Console.WriteLine("Enter string: ");
            //string str = Console.ReadLine();
            //Program obj = new Program();
            //string res = obj.lower_case_string(str);
            //Console.WriteLine(res);


            //find_long_word
            //Console.WriteLine("Enter sentence:");
            //string sentence = Console.ReadLine();
            //Program obj = new Program();

            //string res = obj.find_long_word(sentence);
            //Console.WriteLine(res);

            //Print Odd Numbers 1 to 99
            //Console.WriteLine("The odd numbers from 1 to 99");
            //Program pro = new Program();

            //string res = pro.Odd_Number();
            //Console.WriteLine(res);


            ////27. Sum of Digits in Integer
            //Console.WriteLine("Enter Number: ");
            //long num = long.Parse(Console.ReadLine());

            //Program obj = new Program();
            //long res = obj.sumOfDigits(num);
            //Console.WriteLine(res);

            //Reverse Words in Sentence
            //Console.WriteLine("Enter the sentence");
            //string sentence = Console.ReadLine();

            //string[] rev = sentence.Split(' ');

            //    for(int i=rev.Length-1;i>=0;i--)
            //    {
            //        Console.WriteLine(rev[i]);
            //    }






        //public long sumOfDigits(long number)
        //{
        //    long val = 0;
        //    while(number >0)
        //    {
        //        val = val + (number % 10);
        //        number = number / 10;
        //    }

        //    return val;

        //}

        //public string Odd_Number()
        //{
        //    for(int i=1;i<=99;i++)
        //    {
        //        if(i % 2 != 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //    return "Conpleted...";
        //}

        //public string find_long_word(string sentence)
        //{
        //    string[] words = sentence.Split(' ');
        //    string longg = "";
        //    foreach (string word in words)
        //    {
        //        if (word.Length > longg.Length)
        //        {
        //            longg = word;
        //        }
        //    }
        //    return longg;
        //}
        //public string lower_case_string(string str)
        //{
        //    string val = str;
        //    return val.ToLower();

        //}
 


//public int findval(int first,int second)
//{
//    int res = 0;

//    if (first < second)
//    {
//        res = first - second;
//        return Math.Abs(res);
//    }
//    else if (first > second)
//    {
//        res = 2 * (first - second);
//        return Math.Abs(res);
//    }
//    else
//    {
//        return 0;
//    }

//}

//public int Adding(int first, int second)
//{
//    int sum = 0;
//    sum = first + second;
//    int product = 0;

//    if (first == second)
//    {
//        product = sum * 3;
//        return product;
//    }
//    else
//    {
//        return sum;
//    }
//}












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
