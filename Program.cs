namespace AlgorithmQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = number1;

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
            */
            
            for (int i = 0; i <101; i++)
            {
                Console.WriteLine( i );
                if (i % 20 == 0)
                {

                    for (int j = i; j > 0; j--)
                    {
                        Console.WriteLine(j-1);
                    }
                        
                        
                }
            }
           


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
