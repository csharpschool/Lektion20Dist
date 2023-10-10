using System.Reflection.Emit;

namespace Lektion20Dist.Classes;

public class Animal // Basklass
{
    protected string Name { get; set; }

    public void NameAnimal(string name) => Name = name;

    public void Eat() { }

    public void Poop() { }
}
