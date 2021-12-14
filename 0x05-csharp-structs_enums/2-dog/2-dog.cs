using System;

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string Name, float Age, string Owner, Rating Rating)
    {
        name = Name;
        age = Age;
        owner = Owner;
        rating = Rating;
    }
}
enum Rating
{
    Good,
    Great,
    Excellent,
}
