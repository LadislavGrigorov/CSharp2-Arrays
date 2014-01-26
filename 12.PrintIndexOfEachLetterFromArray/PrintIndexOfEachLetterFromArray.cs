using System;
/*Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.
*/
class PrintIndexOfEachLetterFromArray
{
    static void Main()
    {
        char[] letterArray = new char[] {'A', 'C', 'E', 'G', 'I', 'K', 'M', 'O', 'Q', 'S', 'U', 'W', 'Y', 'Z', 'X', 'V', 'T', 'R', 'P', 'N', 'L', 'J', 'H', 'F', 'D', 'B' };
        Console.Write("Enter a word with capital letters only: ");
        string inputString = Console.ReadLine();
        for (int i = 0; i < inputString.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (inputString[i]==letterArray[j])
                {
                    Console.Write(j + " ");
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}
