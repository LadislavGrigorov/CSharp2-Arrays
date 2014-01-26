using System;
//Write a program that compares two char arrays lexicographically (letter by letter).
class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter first array lenght: ");
        int firstArrayLenght = int.Parse(Console.ReadLine());
        Console.Write("Enter second array lenght: ");
        int secondArrayLenght = int.Parse(Console.ReadLine());
        if (firstArrayLenght == secondArrayLenght)
        {
            char[] firstCharArray = new char[firstArrayLenght];
            char[] secondCharArray = new char[secondArrayLenght];
            for (int i = 0; i < firstArrayLenght; i++)
            {
                Console.Write("Enter char in FirstArray[{0}]: ", i);
                firstCharArray[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < secondArrayLenght; i++)
            {
                Console.Write("Enter char in SecondArray[{0}]: ", i);
                secondCharArray[i] = char.Parse(Console.ReadLine());
            }
            int biggerLenght = Math.Max(firstArrayLenght, secondArrayLenght);
            bool areEqual = true;
            for (int index = 0; index < biggerLenght; index++)
            {
                if (firstCharArray[index] != secondCharArray[index])
                {
                    areEqual = false;
                }
            }
            Console.WriteLine("Are the two arrays equal? " + areEqual);
        }
        else
        {
            Console.WriteLine("The arrays are not equal - their lenght is different.");
        }
    }
}
