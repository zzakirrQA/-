using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ВВедениеООП.Options;

namespace ВВедениеООП.Animals
{
    public class TigerAnimal : AbstractAnimal
    {
        public TigerAnimal(string name, int age) : base(name, age)
        {
            TypeOfAnimal = "Tiger";
            AmountOfFoodForDay = 20;
            Biome = BiomType.Junle;
            Square = 50;
            FoodTypes = new List<FoodType>()
            {
                FoodType.Meat,
            };
            IsPradator = true;
            _sound = "hhggrrr";
        }

        public override Message Play()
        {
            return new Message()
            {
                Text = $"{Name} играет с веревкой",
                SenderName = this.Name,
                SenderType = "Tiger",
                MessageType = MessageType.Play
            };
        }
    }
}
