using System;
/*Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
*/
class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Enter values of array elements:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int currentSequence = 1;
        int maxSequence = 0;
        int sequenceNumber = 0;
        int previousNumber = numbers[0];
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] == previousNumber)
            {
                currentSequence += 1;
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    sequenceNumber = numbers[i];
                }
            }
            else
            {
                currentSequence = 1;
                previousNumber = numbers[i];
            }
        }
        for (int i = 0; i < maxSequence; i++)
        {
            if (i<(maxSequence-1))
            {
                Console.Write("{");
                Console.Write("{0}, ", sequenceNumber);
            }
            else
            {
                Console.Write("{0}", sequenceNumber);
                Console.WriteLine("}");
            }
        }
        if (maxSequence==0)
        {
            Console.WriteLine("There are no equal sequence members.");
        }
    }
}
