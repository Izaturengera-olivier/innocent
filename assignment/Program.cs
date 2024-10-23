using System;

class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();

        
        Mammal lion = new Mammal("Leo", "Lion", 5, "Short");
        Bird parrot = new Bird("Polly", "Parrot", 2, 0.5);
        Reptile snake = new Reptile("Slither", "Snake", 3, true);

        
        zoo.AddAnimal(lion);
        zoo.AddAnimal(parrot);
        zoo.AddAnimal(snake);

        
        Enclosure lionEnclosure = new Enclosure("Lion's Den", 500, "Savannah");
        Enclosure parrotEnclosure = new Enclosure("Bird Aviary", 200, "Tropical");
        
        
        zoo.CreateEnclosure(lionEnclosure);
        zoo.CreateEnclosure(parrotEnclosure);

        
        zoo.AssignAnimalToEnclosure(lion, lionEnclosure);
        zoo.AssignAnimalToEnclosure(parrot, parrotEnclosure);
        
        Zookeeper zookeeper = new Zookeeper("John", "Mammals");
        zoo.HireZookeeper(zookeeper);

        
        zoo.AssignEnclosureToZookeeper(zookeeper, lionEnclosure);
        
        zoo.SimulateDay();
    }
}