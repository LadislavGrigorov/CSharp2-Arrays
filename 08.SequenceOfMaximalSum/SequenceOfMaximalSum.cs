using System;
/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
*/
class SequenceOfMaximalSum
{
    static void Main()
    {
        Console.Write("Enter size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int maxSum = 0;
        Console.WriteLine("Enter values of the array elements: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter array[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int sumCounter = 0;
        int firstMember = 0;
        int secondMember = 0;
        while (sumCounter<n)
        {
            for (int i = 0; i < n - sumCounter; i++)
            {
                int sum = 0;
                for (int j = i; j <= i + sumCounter; j++)
                {
                    sum += numbers[j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    firstMember = i;
                    secondMember = i + sumCounter;
                }
                sum = 0;
            }
            sumCounter++;
        }
        for (int i = firstMember; i <= secondMember; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
