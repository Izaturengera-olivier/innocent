public class Bird : Animal
{
    public double Wingspan { get; set; }

    public Bird(string name, string species, int age, double wingspan) 
        : base(name, species, age)
    {
        Wingspan = wingspan;
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"{Name} the {Species} chirps!");
    }
}

