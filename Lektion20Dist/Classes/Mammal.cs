namespace Lektion20Dist.Classes;

abstract public class Mammal : Animal
{
    abstract public void Move();

    public void Run() { Move(); }

    virtual public string GetName()
    {
        return Name;
    }
}
