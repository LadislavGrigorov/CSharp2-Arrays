using System;
/*Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
*/
class PrimeNumbersSieveOfEratosthenes
{
    static void Main()
    {
        int[] numbers = new int[10000000];
        int number = 1;
        for (int i = 0; i < 10000000; i++)
        {
            numbers[i] = number;
            number++;
        }
        for (int i = 0; i < 10000000; i++)
        {
            if (numbers[i]!=1)
            {
                Console.WriteLine(numbers[i]);
                for (int j = i + 1; j < 10000000; j++)
                {
                    if (numbers[j]%numbers[i]==0)
                    {
                        numbers[j] = 1;
                    }
                }
            }
        }
    }
}
