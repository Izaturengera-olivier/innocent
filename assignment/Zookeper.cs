using System.Collections.Generic;

public class Zookeeper
{
    public string Name { get; set; }
    public string Specialization { get; set; }
    public List<Enclosure> AssignedEnclosures { get; private set; }

    public Zookeeper(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
        AssignedEnclosures = new List<Enclosure>();
    }

    public void AssignEnclosure(Enclosure enclosure)
    {
        AssignedEnclosures.Add(enclosure);
    }

    public void RemoveEnclosure(Enclosure enclosure)
    {
        AssignedEnclosures.Remove(enclosure);
    }
}