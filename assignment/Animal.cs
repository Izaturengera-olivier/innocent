public abstract class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }

    public Animal(string name, string species, int age)
    {
        Name = name;
        Species = species;
        Age = age;
    }

    public abstract void MakeNoise();
}