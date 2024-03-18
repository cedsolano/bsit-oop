using System;

// Encapsulation: Public properties encapsulate the internal state of the object
class Shinobi
{
    public string Name;
    public string NinjaRank;
    public string Ability;

    // Constructor initializes the object's attributes
    public Shinobi(string name, string ninjaRank, string ability)
    {
        Name = name;
        NinjaRank = ninjaRank;
        Ability = ability;
    }

    // Abstraction: Methods provide a simplified interface to interact with the object
    public virtual void Train()
    {
        Console.WriteLine($"Name: {Name}\nRank: {NinjaRank}\nAbility: {Ability}");
        Console.WriteLine($"{Name} trains hard to master their abilities and become a skilled ninja.");
    }

    public virtual void AchieveGoal()
    {
        Console.WriteLine($"{Name} achieves their goal and becomes famous for their abilities!");
    }
}

// Inheritance: Hokage class inherits from Shinobi class, extending its functionality
class Hokage : Shinobi
{
    // Constructor initializes the attributes of the Hokage
    public Hokage(string name, string ninjaRank, string ability) : base(name, ninjaRank, ability)
    {
    }

    // Polymorphism: Override method provides a specialized behavior for Hokage
    public override void Train()
    {
        Console.WriteLine($"Name: {Name}\nRank: {NinjaRank}\nAbility: {Ability}");
        Console.WriteLine($"{Name} ascends to the rank of Hokage, leading the village with wisdom and strength!");
    }

    public override void AchieveGoal()
    {
        Console.WriteLine($"{Name} becomes the Seventh Hokage, bringing peace to the village!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Encapsulation, Abstraction: Creating a Shinobi instance representing Naruto
        Shinobi naruto = new Hokage("Naruto Uzumaki", "Hokage", "Six Paths Sage Mode");
        // Polymorphism: Calling methods on Shinobi instance without knowing the specific subclass
        naruto.Train();
        naruto.AchieveGoal();

        Console.WriteLine();

        // Encapsulation, Abstraction: Creating a Shinobi instance representing Sasuke
        Shinobi sasuke = new Shinobi("Sasuke Uchiha", "Villain", "1 Indra's Arrow");
        // Polymorphism: Calling methods on Shinobi instance without knowing the specific subclass
        sasuke.Train();
        Console.WriteLine($"{sasuke.Name} undergoes redemption and ultimately becomes a hero or 'Shadow Hokage'.");
    }
}
