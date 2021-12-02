using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        myList.Sort();
        for (int count = 0; count < myList.Count; count++)
        {
            if (count == 0 || myList[count] != myList[count - 1])
                sum += myList[count];
        }
        return sum;
    }
}
