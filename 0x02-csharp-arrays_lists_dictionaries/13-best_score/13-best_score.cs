using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int bestVal = 0;
        KeyValuePair<string, int> bestKey = new KeyValuePair<string, int>();
        foreach (KeyValuePair<string, int> element in myList)
        {
            if (element.Value > bestVal)
            {
                bestVal = element.Value;
                bestKey = element;
            }
        }
        return bestKey.Key;
    }
}
