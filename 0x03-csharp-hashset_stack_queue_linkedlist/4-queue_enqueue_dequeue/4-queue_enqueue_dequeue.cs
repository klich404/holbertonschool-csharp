using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int count = aQueue.Count;
        bool isIn = aQueue.Contains(search);

        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: {0}", aQueue.Peek());

        Console.WriteLine("Queue contains \"{0}\": {1}", search, isIn);

        if (isIn == true)
            while (aQueue.Dequeue() != search)
                continue;

        aQueue.Enqueue(newItem);
        return aQueue;
    }
}
