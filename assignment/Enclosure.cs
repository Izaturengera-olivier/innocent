using System.Collections.Generic;

public class Enclosure
{
    public string Name { get; set; }
    public double Size { get; set; }
    public string EnvironmentType { get; set; }
    public List<Animal> Animals { get; private set; }

    public Enclosure(string name, double size, string environmentType)
    {
        Name = name;
        Size = size;
        EnvironmentType = environmentType;
        Animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public void RemoveAnimal(Animal animal)
    {
        Animals.Remove(animal);
    }
}