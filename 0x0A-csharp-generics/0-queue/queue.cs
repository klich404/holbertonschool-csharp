using System;

///<summary>Generic class</summary>
public class Queue<T>
{
    ///<summary>returns the Queue’s type</summary>
    public string CheckType()
    {
        return(typeof(T).ToString());
    }
}
