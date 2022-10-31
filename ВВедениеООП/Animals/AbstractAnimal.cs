using System;
using ВВедениеООП.Options;
using ВВедениеООП;

namespace ВВедениеООП.Animals
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public BiomType Biome { get; protected set; }
        public int Square { get; set; }
        public string[] Eat { get; protected set; }
        public bool IsPradator { get; protected set; }
        protected string _sound;

        public AbstractAnimal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ToEat(string eat, int kg)
        {
            if (Eat.Contains(eat))
            {
                Console.WriteLine($"{Name} поел {kg} килограмма {eat}");
            }
            else
            {
                Console.WriteLine($"{Name} отказался от {eat}");
            }
        }

        public virtual Message ToSound()
        {
            return new Message()
            {
                Text = $"{this.Name} издает звуки {_sound}",
                Name = this.Name,
                MessageType = MessageType.Play
            };
        }

        public abstract void Play();
    }
}
