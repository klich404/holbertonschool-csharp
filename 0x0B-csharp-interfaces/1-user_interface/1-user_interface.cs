using System;

/// <summary>
/// Base - abstract class
/// </summary>
public abstract class Base
{
	/// <summary>
	/// name - public property
	/// </summary>
	public string name { get; set; }

	/// <summary>
	/// ToString - override of 'ToString'
	/// </summary>
	/// <returns>'name' is a 'type'</returns>
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

/// <summary>
/// TestObject - class to test inherits from abstract class and interfaces
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	/// <summary>
	/// durability property
	/// </summary>
	public int durability { get; set; }

	/// <summary>
	/// isCollected property
	/// </summary>
	public bool isCollected { get; set; }

	/// <summary>
	/// Interact implementation
	/// </summary>
	public void Interact()
	{
		return;
	}

	/// <summary>
	/// Break implementation
	/// </summary>
	public void Break()
	{
		return;
	}

	/// <summary>
	/// Collect implementation
	/// </summary>
	public void Collect()
	{
		return;
	}
}
