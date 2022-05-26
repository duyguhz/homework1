using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Aysen", "Orxan", "Akif", "Shebnem", "Durdane" };

            var wantedCount = NameCount(names);
            Console.WriteLine(wantedCount);
            int[] mixNumbers = { 4, 7, 6, 87, 33, 22, 43 };



        }//Verilmis adlar siyahisinda (string array) nece adin uzunlugunun
         //5-den boyuk oldugunu tapan proqram
        static int NameCount(string[] names)
        {
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names.Length > 5)
                    count++;
            }



            return count;

        }// Verilmis ededler siyahisindaki cut ededlerden ibraret yeni bir array qaytaran method.
         // Misalcun gonderilmis ededler siyahisinda {1,3,4,5,6} deyerleri varsa
         // method geriye {4,6} deyerlerinden ibaret bir array qaytarmalidir
         static int EvenNumbers(int[]mixNumbers, int[] evenNumbers)
        {
            for (int i = 0; i < mixNumbers.Length; i++)
            {
                if (mixNumbers[i] % 2 == 0)
                   
                {
                   
                }
            } 
        }


    }   
}

           
