namespace PrototypeDesignPattern;

/// <summary>
/// The ConcretePrototype class
/// </summary>
public class Sandwich : SandwichPrototype
{
    private readonly string Bread;
    private readonly string Meat;
    private readonly string Cheese;
    private readonly string Veggies;

    public Sandwich(string bread, string meat, string cheese, string veggies)
    {
        Bread = bread;
        Meat = meat;
        Cheese = cheese;
        Veggies = veggies;
    }

    public override SandwichPrototype? Clone()
    {
        return MemberwiseClone() as SandwichPrototype;
    }

    public override string GetDetails()
    {
        return string.Format("(Bread: {0}) - (Meat: {1}) - (Cheese: {2}) - (Veggies: {3})", Bread, Meat, Cheese, Veggies);
    }
}
