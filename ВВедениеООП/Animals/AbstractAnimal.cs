using System;
using ВВедениеООП.Options;
using ВВедениеООП;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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
        public int HungerLevel { get; protected set; }
        protected int _neededFood;

        public AbstractAnimal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Message IsSatiety()
        {
            if(HungerLevel < _neededFood)
            {
                return new Message()
                {
                    Text = $"{Name} голодный",
                    Name = this.Name,
                    MessageType = MessageType.Satiety
                };
            }
            else
            {
                return new Message()
                {
                    Text = $"{Name} сытый",
                    Name = this.Name,
                    MessageType = MessageType.Satiety
                };
            }
        }
        public Message TheNeedForFood()
        {

        }
        /*public Message ToEat(string eat, int kg)
        {
            if (Eat.Contains(eat))
            {
                return new Message
                {
                    Text = $"{Name} поел {kg} килограмма {eat}",
                    Name = this.Name,
                    MessageType = MessageType.Eat
                };
            }
            else
            {
                return new Message
                {
                    Text = $"{Name} отказался от {eat}",
                    Name = this.Name,
                    MessageType = MessageType.Eat
                };
            }
        }*/
        public MultipleMessage ToEat()
        {
            if (IsEat().Count>0)
            {
                int i = 0;
                MultipleMessage message = new MultipleMessage();
                message.Name = this.Name;
                message.MessageType = MessageType.Eat;
                while (HungerLevel<5)
                {
                    message.Texts[i] = $"{Name} поел {IsEat()[i].Amount} {IsEat()[i].Name}";
                    HungerLevel += IsEat()[i].Amount;
                    i++;
                }
            }
        }

        public List<Feed> IsEat(Lis)
        {
            List<Feed> ToChtoMojnoEst = new List<Feed>();
            for (int i = 0; i < Valier.Feeder.Count; i++)
            {
                for (int j = 0; j < Eat.Length; j++)
                {
                    if(Valier.Feeder[i].Name == Eat[j])
                    {
                        ToChtoMojnoEst.Add(Valier.Feeder[i]);
                    }
                }
            }
            return ToChtoMojnoEst;

        }
        public virtual Message ToSound()
        {
            return new Message()
            {
                Text = $"{this.Name} издает звуки {_sound}",
                Name = this.Name,
                MessageType = MessageType.Sound
            };
        }

        public abstract Message Play();
    }
}
