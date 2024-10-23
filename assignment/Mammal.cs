public class Mammal : Animal
{
    public string FurType { get; set; }

    public Mammal(string name, string species, int age, string furType) 
        : base(name, species, age)
    {
        FurType = furType;
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"{Name} the {Species} makes a mammal noise!");
    }
}