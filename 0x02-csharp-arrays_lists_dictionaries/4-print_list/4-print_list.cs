using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> list = new List<int>();
        for (int count = 0; count < size; count++)
        {
            list.Add(count);
            if (count != 0)
                Console.Write(" ");
            Console.Write(count);
        }
        Console.WriteLine();
        return list;
    }
}
