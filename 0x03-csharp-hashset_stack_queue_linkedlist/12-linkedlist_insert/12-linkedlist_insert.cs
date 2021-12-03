using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        LinkedListNode<int> holder = myLList.First;
        if (holder == null)
        {
            myLList.AddFirst(newNode);
            return newNode;
        }
        if (holder.Value > n)
        {
            myLList.AddBefore(holder, newNode);
            return newNode;
        }
        while (holder.Next != null)
        {
            if (holder.Next.Value >= n)
                break;
            holder = holder.Next;
        }
        myLList.AddAfter(holder, newNode);
        return newNode;
    }
}
