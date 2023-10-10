namespace ClassLibrary1.Classes;

public class PrviateBaseClass
{
    private class PrviateClass
    {
        public int SomeValue { get; set; } = 7;
    }

    PrviateClass priv = new();

    public double Calculate(double value)
    {
        return priv.SomeValue * value;
    }
}
