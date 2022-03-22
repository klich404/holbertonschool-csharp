﻿using System;

///<summary> Base class </summary>
abstract class Base
{
    public string name;

    ///<summary> String override </summary>
    public override string ToString()
    {
        return (name + " is a " + this.GetType().ToString());
    }
}
