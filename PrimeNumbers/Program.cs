using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int.TryParse(Console.ReadLine(), out var number);

            while (number <= 1)
            {
                Console.WriteLine("Please enter a valid number, which is greater than 1");
                int.TryParse(Console.ReadLine(), out number);
            }

            PrimeNumber prime = new PrimeNumber();
            var resultList = prime.GetPrimeList(number);
            var tableList = prime.CreatePrimeMultiplicationTable(resultList);

            foreach (int p in resultList)
            {
                Console.Write($"{p,5}{"|",2}");
            }

            Console.WriteLine();

            for (int i = 0; i < tableList.Count; i++)
            {
                for (int j = 0; j < tableList.Count; j++)
                {
                    Console.Write($"{tableList[i][j],5}{"|",2}");
                }

                Console.WriteLine();
            }
        }
    }
}
