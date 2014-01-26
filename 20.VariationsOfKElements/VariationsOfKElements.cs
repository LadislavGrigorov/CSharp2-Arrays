using System;
/*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
*/
class VariationsOfKElements
{
    static int n;
    static int k;
    static int[] loops;
    static void VariationOfElements(int currentLoop)
    {
        if (currentLoop == n)
        {
            PrintArray();
            return;
        }
        for (int counter = 1; counter <= k; counter++)
        {
            loops[currentLoop] = counter;
            VariationOfElements(currentLoop + 1);
        }
    }
    static void PrintArray()
    {
        foreach (int number in loops)
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
        loops = new int[n];
        VariationOfElements(0);
    }
}
