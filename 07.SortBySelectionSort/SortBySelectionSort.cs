using System;
/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/
class SortBySelectionSort
{
    static void Main()
    {
        Console.Write("Enter size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int minValue = 0;
        int minValuePosition = 0;
        Console.WriteLine("Enter values of the array elements: ");
        for (int i = 0; i < n; i++) 
        {
            Console.Write("Enter array[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)          //take every number from 1 to N
        {
            minValue = numbers[i];
            for (int j = i; j < n; j++)   //compare the number to the rest of the numbers
            {
                if (numbers[j]<=minValue)               //find the smallest
                {
                    minValue = numbers[j];           //record the smallest number in minVallue
                    minValuePosition = j;            //record the smallest number position
                }
            }
            numbers[minValuePosition] = numbers[i];  //change the smallest number from current itteration to the current number
            numbers[i] = minValue;                   //set the current number to the smallest number from the rest
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
