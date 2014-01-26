using System;
/*Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/
class SequenceSum
{
    static void Main()
    {
        Console.Write("Enter the sum you want: ");
        int inputSum = int.Parse(Console.ReadLine());
        Console.Write("Enter size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Enter values of the array elements: ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int membersCounter = 0;
        int sum = 0;
        while (membersCounter<n)
        {
            for (int i = 0; i < n - membersCounter; i++)
            {
                for (int j = i; j <= i+membersCounter; j++)
                {
                    sum += numbers[j];
                }
                if (sum == inputSum)
                {
                    for (int j = i; j <= i + membersCounter; j++)
                    {
                        Console.Write(numbers[j] + " ");
                    }
                }
                sum = 0;
            }
            membersCounter++;
        }
    }
}
