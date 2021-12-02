using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();
        for (int x = 0; x < list1.Count; x++)
        {
            for (int y = 0; y < list2.Count; y++)
            {
                if (list1[x] == list2[y])
                    newList.Add(list1[x]);
            }
        }
        return newList;
    }
}
