namespace MediatorDesignPattern;

public interface IMediator
{
    void SendMessage(Colleague colleague, string message);
}
