﻿using System;

namespace _1_last_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int number = rndm.Next(-10000, 10000);
            int last_digit = number % 10;
            Console.Write("The last digit of {0} is ", number);
            if (last_digit > 5)
                Console.WriteLine("{0} and is greater than 5", last_digit);
            else if (last_digit == 0)
                Console.WriteLine("{0} and is 0", last_digit);
            else
                Console.WriteLine("{0} and is less than 6 and not 0", last_digit);
        }
    }
}
