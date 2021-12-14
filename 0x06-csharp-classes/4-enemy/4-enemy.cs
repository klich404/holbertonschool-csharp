using System;

namespace Enemies
{
    ///<summary>A zombie class</summary>
    public class Zombie
    {
        ///<summary>health counter for a zombie obj</summary>
        public int health;
        String name = "(No name)";

        ///<summary>A zombie initialization</summary>
        public Zombie()
        {
            health = 0;
        }

        ///<summary>A zombie initialization</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }

        ///<summary>Return the healt of the zombie obj</summary>
        public int GetHealth()
        {
            return health;
        }

        ///<summary>set and get the Name property</summary>
        public string Name
        {
            get{return name;}
            set{name = value;}
        }
    }
}
