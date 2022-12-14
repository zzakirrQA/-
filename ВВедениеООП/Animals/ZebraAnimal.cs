using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ВВедениеООП.Options;

namespace ВВедениеООП.Animals
{
    public class ZebraAnimal : AbstractAnimal
    {
        public ZebraAnimal(string name, int age) : base(name, age )
        {
            TypeOfAnimal = "Herbivore";
            AmountOfFoodForDay = 10;
            Biome = BiomType.Tropic;
            Square = 50;
            FoodTypes = new List<FoodType>()
            {
                FoodType.Leaves,
                FoodType.Seno,
                FoodType.Grass
            };
            IsPradator = false;
            _sound = "viyt-viyt-viyt";
        }

        public override Message Play()
        {
          
            return new Message()
            {
                Text = $"{Name} бегает",
                SenderName = this.Name,
                SenderType = "Zebra",
                MessageType = MessageType.Play
            };
        }

    }
}
