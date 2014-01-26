using System;
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.


class integersarray

{
    static void Main()
    {
        int[] myIntArray = new int[20];
        for (int i = 0; i < 20; i++)
        {
            myIntArray[i] = i*5;
        }
        for (int i = 0; i < 20; i++)
        {
            Console.Write("{0} ", myIntArray[i]);
        }
        Console.WriteLine();
    }
}
