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

///<summary>A public Rectangle class who inherts from Shape</summary>
public class Rectangle : Shape
{
    private int width = 0;
    private int height = 0;
    ///<summary>A public property from Rectangle</summary>
    public int Width
    {
        get{return width;}
        set
        {
            if (value < 0)
                throw new System.ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
    ///<summary>A public property from Rectangle</summary>
    public int Height
    {
        get{return height;}
        set
        {
            if (value < 0)
                throw new System.ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
    ///<summary>A public property of Rectangle</summary>
    public new int Area()
    {
        return (width * height);
    }
    ///<summary>A public method of Rectangle</summary>
    public override string ToString()
    {
        return "[Rectangle] " + width + " / " + height;
    }
}
///<summary>A public Square class who inherts from Rectangle</summary>
public class Square : Rectangle
{
    private int size = 0;

    ///<summary>A public property of Square</summary>
    public int Size
    {
        get{return size;}
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                size = value;
                Height = value;
                Width = value;
            }
        }
    }
}