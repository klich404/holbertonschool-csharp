using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] array = new int[size];
        for (int count = 0; count < size; count++)
        {
            array[count] = count;
            if (count != 0)
                Console.Write(" ");
            Console.Write(count);
        }
        Console.WriteLine();
        return array;
    }
}
