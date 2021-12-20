using System;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (baseType.IsSubclassOf(derivedType) == true)
            return true;
        return false;
    }
}
