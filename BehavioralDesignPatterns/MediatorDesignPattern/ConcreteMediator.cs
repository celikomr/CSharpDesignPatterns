namespace MediatorDesignPattern;

/// <summary>
/// The 'ConcreteMediator' class
/// </summary>
public class ConcreteMediator : IMediator
{
    public ConcreteColleagueA? ConcreteColleagueA { get; set; }
    public ConcreteColleagueB? ConcreteColleagueB { get; set; }

    public void SendMessage(Colleague colleague, string msg)
    {
        if (colleague == ConcreteColleagueA)
        {
            ConcreteColleagueB?.Receive(msg);
        }
        else
        {
            ConcreteColleagueA?.Receive(msg);
        }
    }
}
