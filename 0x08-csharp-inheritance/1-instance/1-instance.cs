using System;

class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj) == true)
            return true;
        return false;
    }
}
