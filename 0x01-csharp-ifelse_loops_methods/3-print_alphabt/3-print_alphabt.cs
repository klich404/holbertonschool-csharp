using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (byte l = 97; l < 123; l++)
            if (l != 101 && l != 113)
                Console.Write((char)l);
        }
    }
}
