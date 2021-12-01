using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> list = new List<string>();
        foreach (string key in myDict.Keys)
            list.Add(key);
        list.Sort();
        foreach (string key in list)
            Console.WriteLine("{0}: {1}", key, myDict[key]);
    }
}
