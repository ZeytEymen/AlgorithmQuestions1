using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters;

namespace AlgorithmQuestions
{
    internal class Program
    {
















        //123
        //0.index = 1
        //1.index = 2
        //2.index = 3
        public static bool IsPalindrome(int x)
        {
            string metin = x.ToString();
            string metin2 = "";
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(metin[i]);
                metin2 = metin2 + metin[i].ToString();
            }
            if (metin2 == metin)
                return true;
            return false;
        }

        public static bool isPalindrome2(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int s = 0;
            int temp = x;
            while (x > 0)
            {
                int r = x % 10;
                s = s * 10 + r;
                x = x / 10;
            }
            return temp == s;
        }


        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null)
                return "";
            int len = 10000;
            int max = 0;
            int min = 0;
            for (int i = 0; i < strs.Length; i++)
            {
                if (len > strs[i].Length)
                {
                    len = strs[i].Length;
                    min = i;
                }
            }
            len = 0;
            for (int i = 0; i < strs.Length; i++)
            {
                if (len < strs[i].Length)
                {
                    len = strs[i].Length;
                    max = i;
                }
            }
             string prefix = "";
            char c;
            char c2;
            for (int i = 0; i < strs[min].Length; i++)
            { 
                c = strs[min][i];
                c2 = c;
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] == c)
                        continue;
                    else
                    {
                        c2 = strs[j][i];
                        break;
                    }
                }
                if (c2 == c)
                    prefix += strs[min][i];
                else
                    break;
            }

            return prefix;
        }

        public static int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<string,int> romans =  new Dictionary<string,int>();
            romans.Add("I",1);
            romans.Add("V", 5);
            romans.Add("X", 10);
            romans.Add("L", 50);
            romans.Add("C", 100);
            romans.Add("D", 500);
            romans.Add("M", 1000);
            romans.Add("IV", 4);
            romans.Add("IX", 9);
            romans.Add("XL", 40);
            romans.Add("XC", 90);
            romans.Add("CD", 400);
            romans.Add("CM", 900);

 
            for (int i = 0; i < s.Length; i++)
            {
                if( i+ 1 < s.Length && romans.ContainsKey(s.Substring(i,2)) )
                {
                    result += romans[s.Substring(i, 2)];
                    i++;
                }
                else if (romans.ContainsKey(s[i].ToString()))
                {
                    result += romans[s[i].ToString()];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("III"));

            //Console.Write("Bir Sayı Giriniz : ");
            //number1 = Convert.ToInt32(Console.ReadLine());

            //string sayi1 = "100";
            //string sayi2 = "q100";
            //bool result;

            //int sayii1 = Convert.ToInt32(sayi1);
            //int sayii2 = Convert.ToInt32(sayi2);
            //int sayi3 = int.Parse(sayi2);
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("FOR SAYACI : ");
            //    Console.WriteLine(i);
            //}

            /*
             * 0 dan 100 e kadar gidecek
             * her 20li katlarda o anki değerin tekrar 0 a kadar yazımı
             * sonra devam taki 100 e kadar 
             * 1
             * .
             * .
             * .
             * 19
             * 20
             * 19
             * 18
             * .
             * 2
             * 1
             * 0
             * 21
             * 22
             * 23
             * 
             * 
             * Given an integer x, return true if x is a palindrome, and false otherwise.
            */


        }



        public void SumTwoNumbers()
        {
            int number1 = 10;
            int number2 = 50;

            int result = number1 + number2;
            Console.WriteLine(result);

        }

        public void SumTwoNumbers2()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number1 + number2);

        }
    }
}
