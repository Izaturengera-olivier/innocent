public class Reptile : Animal
{
    public bool IsVenomous { get; set; }

    public Reptile(string name, string species, int age, bool isVenomous) 
        : base(name, species, age)
    {
        IsVenomous = isVenomous;
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"{Name} the {Species} hisses!");
    }
}