using System;

///<summary> Interective interface </summary>
interface IInteractive
{
    void Interact();
}

///<summary> Breakable interface </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

///<summary> Collectable interface </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

///<summary> Class that inherits from Base and all interfaces </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    ///<summary> Take place when the object interacts with something </summary>
    public void Interact()
    {

    }

    ///<summary> Take place when the object brakes </summary>
    public void Break()
    {

    }

    ///<summary> Take place when the object collects somenthing </summary>
    public void Collect()
    {

    }
}
