using System;


///<summary> Player class </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary> COnstructor of player class </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary> Prints Player info </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    delegate void CalculateHealth(float health);

    ///<summary> damage system </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            Console.WriteLine("{0} takes 0 damage!", this.name);
            damage = 0f;
        }
        else
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        this.hp -= damage;
        ValidateHP(this.hp);
    }

    ///<summary> healing system </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            Console.WriteLine("{0} heals 0 HP!", this.name);
            heal = 0f;
        }
        else
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        this.hp += heal;
        ValidateHP(this.hp);
    }

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0f;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }
}
