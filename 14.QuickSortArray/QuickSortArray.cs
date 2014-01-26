using System;
/*Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
*/
class QuickSortArray
{
    static void PrintSortedArray(string[] arrayOfStrings)
    {
        for (int i = 0; i < arrayOfStrings.Length; i++)
        {
            Console.WriteLine(arrayOfStrings[i]);
        }
    }
    static void QuickSort(string[] arrayOfStrings, int left, int right)
    {
        int leftIndex = left;
        int rightIndex = right;
        string leftString = arrayOfStrings[leftIndex];
        string rightString = arrayOfStrings[rightIndex];
        int pivot = (leftIndex + rightIndex) / 2;
        string pivotString = arrayOfStrings[pivot];
        string swapValue = "";
        while (leftIndex<=rightIndex)
        {
            while (arrayOfStrings[leftIndex].CompareTo(pivotString)<0)
            {
                leftIndex++;
                leftString = arrayOfStrings[leftIndex];
            }
            while (arrayOfStrings[rightIndex].CompareTo(pivotString) > 0)
            {
                rightIndex--;
                rightString = arrayOfStrings[leftIndex];
            }
            if (leftIndex <= rightIndex)
            {
                swapValue = arrayOfStrings[leftIndex];
                arrayOfStrings[leftIndex++] = arrayOfStrings[rightIndex];
                arrayOfStrings[rightIndex--] = swapValue;
            }
        }
        if (left < rightIndex)
        {
            QuickSort(arrayOfStrings, left, rightIndex);
        }
        if (leftIndex < right)
        {
            QuickSort(arrayOfStrings, leftIndex, right);
        }
    }
    static void Main()
    {
        string[] arrayOfStrings = new string[] 
        {
           "jhjftybmhffd",
           "gosho",
           "rangel",
           "pesho",
           "ivan",
           "dimitur",
           "aleksandur",
           "dssdadadsfghhhhh",
           "sddssddsdsdsaaaa",
           "jhjllljhuubooopppp"
       };
        QuickSort(arrayOfStrings, 0, arrayOfStrings.Length-1);
        PrintSortedArray(arrayOfStrings);
    }
}
