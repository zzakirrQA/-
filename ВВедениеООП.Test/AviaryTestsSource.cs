using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ВВедениеООП;
using ВВедениеООП.Animals;
using ВВедениеООП.Options;
namespace ВВедениеООП.Test
{
    public class AddAnimalTestSourсe : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AbstractAnimal animal = new TigerAnimal("Tigrica", 1);
            Aviary aviary = new Aviary("AviaryJungle", BiomType.Junle, 80);

            Aviary expectedAviary = new Aviary("AviaryJungle", BiomType.Junle, 80);
            expectedAviary.AddAnimal((new TigerAnimal("Tigrica", 1)));
            Message expectedMessage = new Message()
            {
                Text = $"В AviaryJungle подселился Tigrica",
                SenderName = "AviaryJungle",
                SenderType = "Aviary",
                MessageType = MessageType.AddingAnimal
            };
            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };


            animal = new MonkeyAnimal("Maymun", 2);
            aviary = new Aviary("AviaryForest", BiomType.Forest, 50);
            aviary.AddAnimal((new MonkeyAnimal("Maymun", 2)));

            expectedAviary = new Aviary("AviaryForest", BiomType.Forest, 50);
            expectedAviary.AddAnimal((new MonkeyAnimal("Maymun", 2)));
            expectedAviary.AddAnimal((new MonkeyAnimal("Maymun", 2)));
            expectedMessage = new Message()
            {
                Text = $"В AviaryForest подселился Maymun",
                SenderName = "AviaryForest",
                SenderType = "Aviary",
                MessageType = MessageType.AddingAnimal
            };
            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };


            animal = new ElephantAnimal("Fil", 2,40);
            aviary = new Aviary("AviaryTropic", BiomType.Tropic, 50);

            expectedAviary = new Aviary("AviaryTropic", BiomType.Tropic, 50);
            expectedAviary.AddAnimal((new ElephantAnimal("Fil", 2,40)));
            expectedMessage = new Message()
            {
                Text = $"В AviaryTropic не подселился Fil, так как нет свободного места",
                SenderName = "AviaryTropic",
                SenderType = "Aviary",
                MessageType = MessageType.AddingAnimalFailed
            };
            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };
        }
    }
}
