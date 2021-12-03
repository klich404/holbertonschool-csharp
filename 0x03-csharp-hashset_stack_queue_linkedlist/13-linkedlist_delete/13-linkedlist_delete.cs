using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int ind = 0;
        LinkedListNode<int> holder = myLList.First;

        for (; ind < index && holder.Next != null; ind++)
            holder = holder.Next;
        if (ind == index)
            myLList.Remove(holder);
    }
}
