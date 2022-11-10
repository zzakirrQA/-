using ВВедениеООП.Options;
using ВВедениеООП;
using ВВедениеООП.Animals;
using System.Collections;
using System.Collections.Generic;

Console.WriteLine();


List<int> ints = new List<int>() { 1,2,3};
List<int> ints2 = new List<int>() { 4,5,6};
ints = ints2;
foreach (var item in ints)
{
    Console.WriteLine(item);
}









/*ElephantAnimal elephant = new ElephantAnimal("SLON", 4, 3);
ZebraAnimal zebra = new ZebraAnimal("Zebra", 2);

Message[] messages = elephant.ToSound(5);
for (int i = 0; i < messages.Length; i++)
{
    Console.WriteLine(messages[i].Text);
}

List<AbstractAnimal> animals = new List<AbstractAnimal>();
animals.Add(elephant);
animals.Add(zebra);
animals.Add(new ElephantAnimal("slon", 2, 1));
*/
/*foreach (AbstractAnimal animal in animals)
{
    //animal.Play();
    
    if (animal is ElephantAnimal)
    {
        //((ElephantAnimal)animal).ToSound(3);
        Console.WriteLine(animal.ToSound().Text);
    }
}*/

