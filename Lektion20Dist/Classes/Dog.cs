namespace Lektion20Dist.Classes;

// sealed betyder får inte ärvas,
// vi måste skapa instanser
sealed public class Dog : Mammal
{
    public Dog() //: base()
    {
        
    }
    // sealed betyder får inte överskridas med override i
    // en ärvande klass (t.ex. Newfounland).
    // Sealed på metod aanvänds inte i en sealed
    // klass pga att den inte får ärvas. 
    sealed public override string GetName()
    {
        //return "Snoopy";
        var name = base.GetName();
        return $"Hunden heter {name}";
    }

    // Måste finnas pga att Move metoden i Mammal
    //är abstract utan implementation
    public override void Move() 
    {
        throw new NotImplementedException();
    }
}
