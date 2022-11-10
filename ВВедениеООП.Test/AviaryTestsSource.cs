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

            //for space
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

            //for biom
            animal = new BearAnimal("Masa", 2);
            aviary = new Aviary("AviarySavanna", BiomType.Savanna, 200);

            expectedAviary = new Aviary("AviarySavanna", BiomType.Savanna, 200);
            expectedAviary.AddAnimal((new BearAnimal("Masa", 2)));
            expectedMessage = new Message()
            {
                Text = $"В AviarySavanna не подселился Masa, так как биомы не совпадают",
                SenderName = "AviarySavanna",
                SenderType = "Aviary",
                MessageType = MessageType.AddingAnimalFailed
            };
            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };
        }

    }

    public class MakeSoundAllTestSource:IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            List<AbstractAnimal> animals = new List<AbstractAnimal>();
            AbstractAnimal animal1 = new ZebraAnimal("mokoto", 1);
            animals.Add(animal1);
            AbstractAnimal animal2 = new ZebraAnimal("komoto", 1);
            animals.Add(animal2);
            AbstractAnimal animal3 = new ZebraAnimal("momoto", 1);
            animals.Add(animal3);
            Aviary aviary = new Aviary("ForZebr",BiomType.Tropic, 300);
            aviary.Animals = animals;
            List<Message> messages = aviary.MakeSoundAll();

            List<Message> expectedMessages = new List<Message>()
            {
                new Message()
                {
                    Text = $"mokoto izdaet zvuki viyt-viyt-viyt",
                    SenderName = "mokoto",
                    SenderType = "Herbivore",
                    MessageType = MessageType.Sound
                },
                 new Message()
                {
                    Text = $"komoto izdaet zvuki viyt-viyt-viyt",
                    SenderName = "komoto",
                    SenderType = "Herbivore",
                    MessageType = MessageType.Sound
                },
                  new Message()
                {
                    Text = $"momoto izdaet zvuki viyt-viyt-viyt",
                    SenderName = "momoto",
                    SenderType = "Herbivore",
                    MessageType = MessageType.Sound
                }
            };
            yield return new object[] {messages,expectedMessages};


        }
    }
}
