using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ВВедениеООП.Options;

namespace ВВедениеООП.Animals
{
    public class BearAnimal:AbstractAnimal
    {
        public BearAnimal(string name, int age) : base(name, age)
        {
            TypeOfAnimal = "Bear";
            AmountOfFoodForDay = 30;
            Biome = BiomType.Forest;
            Square = 70;
            FoodTypes = new List<FoodType>()
            {
                FoodType.Honey,
                FoodType.Fish
            };
            IsPradator = true;
            _sound = "hhaagrr";
        }

        
        public override Message Play()
        {
            return new Message()
            {
                Text = $"{Name} лазит по деревьям",
                SenderName = this.Name,
                SenderType = "Bear",
                MessageType = MessageType.Play
            };

        }
    }
}
