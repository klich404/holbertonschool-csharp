using System;

///<summary> Base class </summary>
public abstract class Base
{
    ///<summary> Name of instance </summary>
    public string name;

    ///<summary> String override </summary>
    public override string ToString()
    {
        return (name + " is a " + this.GetType().ToString());
    }
}

/// <summary> Defines the properties of an interactive object </summary>
interface IInteractive
{
    void Interact();
}

/// <summary> Defines the properties of a breakable object </summary>
interface IBreakable
{
    int durability { get; set; }
}

/// <summary> Defines the properties of a collectable object </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary> A test object for inheriting interfaces </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }
    
    public void Interact()
    {

    }

    public void Collect()
    {

    }
}
