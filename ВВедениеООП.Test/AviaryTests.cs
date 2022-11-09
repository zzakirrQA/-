global using NUnit.Framework;
using ВВедениеООП;
using ВВедениеООП.Animals;

namespace ВВедениеООП.Test
{

    public class AviaryTests
    {
        [TestCaseSource(typeof(AddAnimalTestSourсe))]
        public void AddAnimalTest(AbstractAnimal animal, Aviary aviary, Aviary expectedAviary, Message expectedMessage)
        {
            Message actualMessage = aviary.AddAnimal(animal);
            Aviary actualAviary = aviary;

            Assert.AreEqual(expectedAviary, actualAviary);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}