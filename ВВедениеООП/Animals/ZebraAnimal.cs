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
        public ZebraAnimal(string name, int age) : base(name, age)
        {
            Biome = BiomType.Junle;
            Eat = new string[] { "qqq" };
            _sound = "FirFir";
            IsPradator = false;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} бегает");
        }
    }
}
