namespace PrototypeDesignPattern;

/// <summary>
/// The Prototype abstract class
/// </summary>
public abstract class SandwichPrototype
{
    public abstract SandwichPrototype? Clone();
    public abstract string GetDetails();
}
