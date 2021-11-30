using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (; n < 99; n++)
            {
                Console.Write("{0} = 0x{0:x}\n", n);
            }
        }
    }
}
