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
            Eat = new string[] { "листья", "арбуз","тыква" };
            _sound = "YYYYYYYY";
            IsPradator = false;
            HobotLenght = hobotLenght;
            HungerLevel.
        }

        public ElephantAnimal() : base("", 0)
        {

        }

        public override Message ToSound()
        {
            return new Message
            {
                Text = $"{Name} издает звуки {_sound} из хобота",
            };
        }

        public Message[] ToSound(int n)
        {
            Message[] messages = new Message[n];
            for (int i = 0; i < n; i++)
            {
                Message message = new Message()
                {
                    Text = $"{Name} издает звуки {_sound} из хобота",
                    Name = this.Name,
                    MessageType = MessageType.Sound
                };
                messages[i] = message;
            }
            return messages;
        }
         
        public override Message Play()
        {
            return new Message()
            {
                Text = $"{Name} делает Пшшшш водичкой"
            };
        }
    }
}



