using System;
/*Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
*/
class BinarySearchAlgorithm
{
    static void Main()
    {
        Console.Write("Enter size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.Write("Enter values of the array elements: ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        Console.Write("Enter the number you want to search: ");
        int inputNumber = int.Parse(Console.ReadLine());
        int index = (n + 1)/2;
        bool areNotEqual = true;
        while (areNotEqual)
        {
            if (inputNumber > numbers[index])
            {
                index = index + (n - index + 1) / 2;
            }
            else if (inputNumber < numbers[index])
            {
                index = (n - index + 1) / 2;
            }
            if (inputNumber == numbers[index])
            {
                areNotEqual = false;
            }
        }
        Console.WriteLine(index); // printing the index of the number
    }
}
