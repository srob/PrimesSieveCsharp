using System;
using System.Collections.Generic;

namespace PrimeSieve
{
    public class Primes
    {
        public static List<int> Generate(int maxValue)
        {
            var primes = new List<int>();
            if (maxValue < 2)
                return primes;

            bool[] isPrime = new bool[maxValue + 1];
            for (int i = 2; i <= maxValue; i++)
                isPrime[i] = true;

            for (int i = 2; i * i <= maxValue; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= maxValue; j += i)
                        isPrime[j] = false;
                }
            }

            for (int i = 2; i <= maxValue; i++)
            {
                if (isPrime[i])
                    primes.Add(i);
            }

            return primes;
        }
    }
}
