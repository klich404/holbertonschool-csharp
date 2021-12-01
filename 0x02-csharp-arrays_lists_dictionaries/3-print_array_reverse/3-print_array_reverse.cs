using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null)
        {
            for (int count = array.Length - 1; count >= 0; count--)
            {
                if (count != array.Length - 1)
                    Console.Write(" ");
                Console.Write(array[count]);
            }
        }
        Console.WriteLine();
    }
}
