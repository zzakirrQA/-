using System;
using ВВедениеООП.Options;
using ВВедениеООП;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ВВедениеООП.Animals
{
    public abstract class AbstractAnimal
    {
        public string TypeOfAnimal { get; protected set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int AmountOfFoodForDay { get; protected set; } 
        public double EatenFood { get; set; }
        public BiomType Biome { get; protected set; }
        public int Square { get; set; }
        public List<FoodType> FoodTypes { get; protected set; }
        public bool IsPradator { get; protected set; }

        protected string _sound;

        public AbstractAnimal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual Message Feed(FoodType eat, double foodWeight)
        {
            string result = "";

            if (!FoodTypes.Contains(eat))
            {
                result = $"{Name} doesn't eat {eat}";
            }
            else if (foodWeight > AmountOfFoodForDay)
            {
                result = $"{foodWeight}kg is too much for {Name}";
            }
            else
            {
                if (EatenFood + foodWeight > AmountOfFoodForDay)
                {
                    result = $"{Name} ate {AmountOfFoodForDay - EatenFood}kg of {eat}";
                    EatenFood = AmountOfFoodForDay;
                }
                else
                {
                    result = $"{Name} ate {foodWeight}kg of {eat}";
                    EatenFood += foodWeight;
                }
            }

            return new Message()
            {
                Text = result,
                SenderName = this.Name,
                SenderType = this.TypeOfAnimal,
                MessageType = MessageType.Eat
            };
        }

        public virtual Message MakeSound()
        {
            return new Message()
            {
                Text = $"{Name} izdaet zvuki {_sound}",
                SenderName = this.Name,
                SenderType = this.TypeOfAnimal,
                MessageType = MessageType.Sound
            };
        }

        public abstract Message Play();
    }
}
