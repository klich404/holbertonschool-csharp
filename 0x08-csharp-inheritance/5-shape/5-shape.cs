using System;

///<summary>A Shape class</summary>
public class Shape
{
    ///<summary>A public method who throw a erre</summary>
    public virtual int Area()
    {
        throw new System.NotImplementedException("Area() is not implemented");
    }
}
