﻿using System;

/// <summary> Base abstract class</summary>
public abstract class Base
{
	/// <summary> name propert </summary>
	public string name { get; set; }

	/// <summary> override of toString method</summary>
	public override string ToString()
	{
		return $"{name} is a {this.GetType()}";
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
