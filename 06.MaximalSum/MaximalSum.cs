using System;
//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter array[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        for (int i = numbers.Length - k; i < numbers.Length; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
        
    }
}
