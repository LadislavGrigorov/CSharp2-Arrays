using System;
//Write a program that reads two arrays from the console and compares them element by element.

class CompareTwoArrays
{
    static void Main()
    {
        Console.Write("Enter lenght of the first array: ");
        int firstLenght = int.Parse(Console.ReadLine());
        Console.Write("Enter lenght of the second array: ");
        int secondLenght = int.Parse(Console.ReadLine());
        if (firstLenght!=secondLenght)
        {
            Console.WriteLine("The arrays are not equal.");
        }
        else
        {
            int[] firstArray = new int[firstLenght];
            int[] secondArray = new int[secondLenght];
            for (int i = 0; i < firstLenght; i++)
            {
                Console.Write("Enter integer value for first array - number[{0}]: ", i + 1);
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < secondLenght; i++)
            {
                Console.Write("Enter integer value for second array - number[{0}]: ", i + 1);
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            bool areEqual = true;
            for (int index = 0; index < firstLenght; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    areEqual = false;
                }
            }
            Console.WriteLine("Are the two arrays equal? " + areEqual);
        }
    }
}