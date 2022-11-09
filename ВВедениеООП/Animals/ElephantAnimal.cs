using System;
using ВВедениеООП.Options;

namespace ВВедениеООП.Animals
{
    public class ElephantAnimal : AbstractAnimal
    {
        public int HobotLenght { get; set; }
        public ElephantAnimal(string name, int age, int hobotLenght) : base(name, age)
        {
            HobotLenght = hobotLenght;
            TypeOfAnimal = "Herbivore";
            AmountOfFoodForDay = 50;
            Biome = BiomType.Tropic;
            Square = 100;
            FoodTypes = new List<FoodType>()
            {
                FoodType.Pumpkin,
                FoodType.Watermelon,
                FoodType.Grass
            };
            IsPradator = false;
            _sound = "YYYYYYYY";
        }



        public override Message MakeSound()
        {
            return new Message
            {
                Text = $"{Name} издает звуки {_sound} из хобота",
                SenderName = Name,
                SenderType = "Slon",
                MessageType = MessageType.Sound
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
                    SenderName = this.Name,
                    SenderType = TypeOfAnimal,
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
                Text = $"{Name} делает Пшшшш водичкой",
                SenderName = this.Name,
                SenderType = "Elephant",
                MessageType = MessageType.Play
            };
        }
    }
}



