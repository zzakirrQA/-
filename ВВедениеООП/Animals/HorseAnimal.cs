using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ВВедениеООП.Options;

namespace ВВедениеООП.Animals
{
    public class HorseAnimal:AbstractAnimal
    {
        public HorseAnimal(string name, int age) : base(name, age)
        {
            TypeOfAnimal = "Herbivore";
            AmountOfFoodForDay = 10;
            Biome = BiomType.Meadows;
            Square = 50;
            FoodTypes = new List<FoodType>()
            {
                FoodType.Seno,
                FoodType.Grass
            };
            IsPradator = false;
            _sound = "hiiihaaaa";
        }

        public override Message Play()
        {
            return new Message()
            {
                Text = $"{Name} бегает прыгает",
                SenderName = this.Name,
                SenderType = "Horse",
                MessageType = MessageType.Play
            };


        }
    }
}
