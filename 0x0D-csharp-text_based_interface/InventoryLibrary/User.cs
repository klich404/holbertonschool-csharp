using System;

///<summary> User class </summary>
public class User : BaseClass
{
    public string name { get; set; }

    ///<summary> User constructor </summary>
    public User(string name = "name")
    {
        this.name = name;
    }
}