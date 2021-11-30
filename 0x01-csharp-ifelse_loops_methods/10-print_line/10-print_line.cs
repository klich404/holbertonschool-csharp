using System;

class Line
{
    public static void PrintLine(int length)
    {
        for (int count = 0; count < length; count++)
            Console.Write("_");
        Console.WriteLine();
    }
}
