namespace MediatorDesignPattern;

/// <summary>
/// The 'Colleague' abstract class
/// </summary>

public abstract class Colleague
{
    protected IMediator _mediator;

	public Colleague(IMediator mediator)
	{
		_mediator = mediator;
	}
}
