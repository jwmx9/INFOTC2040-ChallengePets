using System;

namespace Pets
{
    class Cat : Pet
    {
        public Cat(string name, string owner, double weight) : base(string.Empty, name, owner, weight)
        {
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public string meow(int count)
        {
            string sound = "";
            for (int i = 0; i < count; i++)
            {
                sound = sound + "meow.";
            }
            return sound;
        }
    }
}
