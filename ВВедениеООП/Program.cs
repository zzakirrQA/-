using ВВедениеООП.Options;
using ВВедениеООП;
using ВВедениеООП.Animals;
using System.Collections;
using System.Collections.Generic;


ElephantAnimal elephant = new ElephantAnimal("SLON", 4, 3);
ZebraAnimal zebra = new ZebraAnimal("Zebra", 2);

List<AbstractAnimal> animals = new List<AbstractAnimal>();
animals.Add(elephant);
animals.Add(zebra);
animals.Add(new ElephantAnimal("slon",2,1));

foreach (AbstractAnimal animal in animals)
{
    animal.Play();
    
    if (animal is ElephantAnimal)
    {
        //((ElephantAnimal)animal).ToSound(3);
        Console.WriteLine(animal.ToSound().MessageType);
    }
}