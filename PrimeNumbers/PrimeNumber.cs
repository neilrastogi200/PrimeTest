using System.Collections.Generic;

namespace PrimeNumbers
{
    public class PrimeNumber
    {
        public List<int> GetPrimeList(int primeNumber)
        {
            var prime = new bool[primeNumber + 1];
            var primeNumberList = new List<int>();

            for (var i = 0; i <= primeNumber; i++)
            {
                prime[i] = true;
            }

            for (var p = 2; p * p <= primeNumber; p++)
            {
                if (p >= 0 && prime.Length > p && prime[p])
                {
                    for (var i = p * p; i <= primeNumber; i += p)
                    {
                        prime[i] = false;
                    }
                }
            }  
            
            //Add to list
            for (var i = 2; i <= primeNumber; i++)
            {
                if (prime[i])
                {
                    primeNumberList.Add(i);
                }        
            }

            return primeNumberList;
        }

        public List<List<int>> CreatePrimeMultiplicationTable(List<int> primeList)
        {
            var primeTable = new List<List<int>>();
            var index = 0;

            foreach (var result in primeList)
            {
                primeTable.Add(new List<int>());

                foreach (var num in primeList)
                {
                    primeTable[index].Add(result * num);
                }

                index++;
            }

            return primeTable;
        }
    }
}
