namespace MediatorDesignPattern;

/// <summary>
/// The 'Mediator' interface
/// </summary>
public interface IMediator
{
    void SendMessage(Colleague colleague, string msg);
}
