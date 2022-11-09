using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ВВедениеООП.Animals;
using ВВедениеООП.Options;

namespace ВВедениеООП
{
    public class Aviary
    {
        public string Name { get; set; }
        public BiomType Biom { get; set; }
        public int TotalArea { get; set; }
        public List<AbstractAnimal> Animals { get; set; }
        public Dictionary<FoodType, int> Feeder { get; set; }

        public Aviary(string name, BiomType biom, int square)
        {
            Name = name;
            Biom = biom;
            TotalArea = square;
            Animals = new List<AbstractAnimal>();
        }
        

        public Message AddAnimal(AbstractAnimal animal)
        {

            if(Biom!=animal.Biome)
            {
                return new Message()
                {
                    Text = $"В {Name} не подселился {animal.Name}, так как биомы не совпадают",
                    SenderName = this.Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.AddingAnimalFailed
                };
            }
            else if(GetFreeSpace()<animal.Square)
            {
                return new Message()
                {
                    Text = $"В {Name} не подселился {animal.Name}, так как нет свободного места",
                    SenderName = this.Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.AddingAnimalFailed
                };
            }
            else if(!IsPodhoditSosedyam(animal))
            {
                return new Message()
                {
                    Text = $"В {Name} не подселился {animal.Name}, из за соседей",
                    SenderName = this.Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.AddingAnimalFailed
                };
            }
            else
            {
                Animals.Add(animal);
                return new Message()
                {
                    Text = $"В {Name} подселился {animal.Name}",
                    SenderName = this.Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.AddingAnimal
                };
            }
        }

        private int GetFreeSpace()
        {
            int freeSpace = TotalArea;
            foreach (var item in Animals)
            {
                freeSpace -= item.Square;
            }
            return freeSpace;

        }

        private bool IsPodhoditSosedyam(AbstractAnimal animal)
        {
            if(Animals.Count != 0)
            {
                foreach (var item in Animals)
                {
                    if ((item.IsPradator || animal.IsPradator) && item.TypeOfAnimal != animal.TypeOfAnimal)
                    {
                        return false;
                    }
                }
            }
            return true;

        }

        public override bool Equals(object? obj)
        {
            return obj is Aviary aviary &&
                   Name == aviary.Name &&
                   Biom == aviary.Biom &&
                   TotalArea == aviary.TotalArea &&
                   Animals.Count == aviary.Animals.Count;
        }
    }
}
