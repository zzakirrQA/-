using System;
using ВВедениеООП.Options;

namespace ВВедениеООП.Animals
{
    public class ElephantAnimal : AbstractAnimal
    {
        public int HobotLenght { get; set; }
        public ElephantAnimal(string name, int age, int hobotLenght) : base(name, age)
        {
            Biome = BiomType.Tropic;
            Eat = new string[] { "qqq", "www" };
            _sound = "YYYYYYYY";
            HobotLenght = hobotLenght;
        }

        public ElephantAnimal() : base("", 0)
        {

        }

        public override Message ToSound()
        {
            return new Message
            {
                Text = $"{Name} издает звуки {_sound} из хобота",
                MessageType = MessageType.Play
            };
        }

        public void ToSound(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{Name} издает звуки {_sound} из хобота");
            }
        }
         
        public override void Play()
        {
            Console.WriteLine($"{Name} делает Пшшшш водичкой");
        }
    }
}



