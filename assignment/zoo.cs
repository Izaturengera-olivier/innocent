using System.Collections.Generic;

public class Zoo
{
    public List<Animal> Animals { get; private set; }
    public List<Enclosure> Enclosures { get; private set; }
    public List<Zookeeper> Zookeepers { get; private set; }

    public Zoo()
    {
        Animals = new List<Animal>();
        Enclosures = new List<Enclosure>();
        Zookeepers = new List<Zookeeper>();
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public void CreateEnclosure(Enclosure enclosure)
    {
        Enclosures.Add(enclosure);
    }

    public void AssignAnimalToEnclosure(Animal animal, Enclosure enclosure)
    {
        if (enclosure.Animals.Count < enclosure.Size) // Check size constraint
        {
            enclosure.AddAnimal(animal);
        }
        else
        {
            Console.WriteLine("Enclosure is full!");
        }
    }

    public void HireZookeeper(Zookeeper zookeeper)
    {
        Zookeepers.Add(zookeeper);
    }

    public void AssignEnclosureToZookeeper(Zookeeper zookeeper, Enclosure enclosure)
    {
        zookeeper.AssignEnclosure(enclosure);
    }

    public void SimulateDay()
    {
        foreach (var animal in Animals)
        {
            animal.MakeNoise();
        }
    }
}