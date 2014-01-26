using System;
/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
*/
class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Enter size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Enter values of the array elements: ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int counter = 0;
        int maxCounter = 0;
        int mostFrequentNumber = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (numbers[i]==numbers[j])
                {
                    counter++;
                }
            }
            if (counter>maxCounter)
            {
                maxCounter = counter;
                mostFrequentNumber = numbers[i];
            }
            counter = 0;
        }
        if (maxCounter>1)
        {
            Console.WriteLine("{0}({1} times)", mostFrequentNumber, maxCounter);
        }
        else
        {
            Console.WriteLine("There is no most frequent number");
        }
    }
}
