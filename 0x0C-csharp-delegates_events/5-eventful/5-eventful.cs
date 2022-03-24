using System;


///<summary> Player class </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
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
        if (newHp < 0f)
            this.hp = 0f;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
        OnCheckStatus(new CurrentHPArgs(this.hp));
    }

    ///<summary> power system </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }

    public event EventHandler<CurrentHPArgs> HPCheck;

    ///<summary> warning when hp is low </summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Health is low!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    ///<summary> check the status of player </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = $"{this.name} is in perfect health!";
        else if (e.currentHp >= (this.maxHp * 0.5f) && e.currentHp < this.maxHp)
            this.status = $"{this.name} is doing well!";
        else if (e.currentHp >= (this.maxHp * 0.25f) && e.currentHp < (this.maxHp * 0.5f))
            this.status = $"{this.name} isn't doing too great...";
        else if (e.currentHp > 0f && e.currentHp < (this.maxHp * 0.5f))
            this.status = $"{this.name} needs help!";
        else
            this.status = $"{this.name} is knocked out!";
        Console.WriteLine(this.status);
    }

    void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < (this.maxHp * 0.25f))
            HPCheck += HPValueWarning;
        HPCheck(this, e);
    }
}

///<summary> modifier </summary>
enum Modifier
{
    Weak,
    Base,
    Strong
}

delegate float CalculateModifier(float baseValue, Modifier modifier);

class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;

    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
