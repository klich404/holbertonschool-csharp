using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary> Base abstract class</summary>
public abstract class Base
{
	/// <summary> name property </summary>
	public string name;

	/// <summary> override of toString method</summary>
	public override string ToString()
	{
		return (this.name + " is a " + this.GetType().ToString());
	}
}

interface IInteractive
{
	void Interact();
}

interface IBreakable
{
	int durability { get; set; }
	void Break();
}

interface ICollectable
{
	bool isCollected { get; set; }
	void Collect();
}

/// <summary> TestObject class that inherits from Base and IIntereactive</summary>
public class Door : Base, IInteractive
{
    ///<summary> new door </summary>
	public Door(string nam = "Door")
    {
        name = nam;
    }

    ///<summary> Takes place when the object intereacts with something </summary> 
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }
}

/// <summary> TestObject class that inherits from Base and IIntereactive</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary> isQuesItem property </summary>
    public bool isQuestItem;
    ///<summary> durability property </summary>
    public int durability { get; set; }

    ///<summary> Decoration constructor </summary>
	public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    ///<summary> Interact method call when the object interacts with something </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The {0} has been broken.", name);
        else if (isQuestItem == true)
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
    }

    ///<summary> Break method call when the object has been broken </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", name);
        else if (durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", name);
        else
            Console.WriteLine("The {0} is already broken.", name);
    }
}

class Key : Base, ICollectable
{
    ///<summary> isCollected property </summary>  
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    ///<summary> Collect method call when the object has been broken </summary>
	public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine("You pick up the {0}.", name);
        }
        else
            Console.WriteLine("You have already picked up the {0}.", name);
    }
}

class RoomObjects
{
    ///<summary> 
    /// IterateAction method list all object and execute methods depending on
    /// what interface that item implements
    ///</summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base item in roomObjects)
        {
            if (type == typeof(IInteractive) && item is IInteractive)
                ((IInteractive)item).Interact();
            else if (type == typeof(IBreakable) && item is IBreakable)
                ((IBreakable)item).Break();
            else if (type == typeof(ICollectable) && item is ICollectable)
                ((ICollectable)item).Collect();
        }
    }
}
