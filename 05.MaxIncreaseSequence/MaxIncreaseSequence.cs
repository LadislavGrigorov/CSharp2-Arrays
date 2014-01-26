using System;
//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

class Program
{
    static void Main()
    {
        Console.Write("Enter size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int difference = 1;
        int firstMember = 0;
        int lastMember = 0;
        int sequenceCounter = 1;
        int maxSequenceCounter = 1;
        Console.WriteLine("Enter value of the array elements: ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int previousMember = numbers[0];
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] - previousMember == difference)
            {
                sequenceCounter++;
                difference++;
                
                if (sequenceCounter > maxSequenceCounter)
                {
                    maxSequenceCounter = sequenceCounter;
                    firstMember = previousMember;
                    lastMember = numbers[i];
                }
            }
            else
            {
                sequenceCounter = 1;
                previousMember = numbers[i];
                difference = 1;
            }
        }
        if (maxSequenceCounter!=1)
        {
            Console.WriteLine("Increasing sequence members:");
            for (int i = firstMember; i <= lastMember; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There are no icreasing sequence members!");
        }
        
    }
}
