using System;

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
            Console.WriteLine("The {0} has been broken.", durability);
        else if (isQuestItem == true)
            Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
    }

    ///<summary> Break method call when the object has been broken </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", this.name);
        else if (durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", this.name);
        else
            Console.WriteLine("The {0} is already broken.", this.name);
    }
}
