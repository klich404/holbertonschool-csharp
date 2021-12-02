using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = aStack.Count;
        bool isIn = aStack.Contains(search);

        Console.WriteLine("Number of items: {0}", aStack.Count);

        if (count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", aStack.Peek());

        Console.WriteLine("Stack contains \"{0}\": {1}", search, isIn);

        if (isIn == true)
            while (aStack.Pop() != search)
                continue;

        aStack.Push(newItem);
        return aStack;
    }
}
