using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ВВедениеООП.Options;

namespace ВВедениеООП.Animals
{
    public class MonkeyAnimal : AbstractAnimal
    {

        public MonkeyAnimal(string name, int age) : base(name, age)
        {
            TypeOfAnimal = "Monkey";
            AmountOfFoodForDay = 5;
            Biome = BiomType.Forest;
            Square = 20;
            FoodTypes = new List<FoodType>()
            {
                FoodType.Banan,
                FoodType.Watermelon,
            };
            IsPradator = false;
            _sound = "ggraa-ggraa";
        }

        public override Message Play()
        {
           
            return new Message()
            {
                Text = $"{Name} прыгает с ветки на ветку",
                SenderName = this.Name,
                SenderType = "Monkey",
                MessageType = MessageType.Play
            };


        }
    }
}
