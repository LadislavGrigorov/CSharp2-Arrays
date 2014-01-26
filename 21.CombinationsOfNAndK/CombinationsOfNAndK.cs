using System;
/*Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
*/
class VariationsOfKElements
{
    static int n;
    static int k;
    static int[] loops;
    static void VariationOfElements(int[] array, int index, int startNumber, int endNumber)
    {
        if (index >= array.Length)
        {
            PrintArray(array);
            return;
        }
        for (int counter = startNumber; counter <= endNumber; counter++)
        {
            loops[index] = counter;
            VariationOfElements(array, index + 1, counter + 1, endNumber);
        }
    }
    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        k = int.Parse(Console.ReadLine());
        loops = new int[k];
        VariationOfElements(loops, 0, 1, n);
    }
}
