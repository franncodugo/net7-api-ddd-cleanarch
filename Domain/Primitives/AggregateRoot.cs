namespace Domain.Primitives;

public abstract class AggregateRoot
{
    /// <summary>
    ///  Domain Events list.
    /// </summary>
    private readonly List<DomainEvent> _domainEvents = new();

    /// <summary>
    /// Getting all the Domain Events within this Aggregate.
    /// </summary>
    /// <returns>List<DomainEvents></returns>
    public ICollection<DomainEvent> GetDomainEvents()
        => _domainEvents;

    /// <summary>
    ///  Raise a Domain Event.
    /// </summary>
    protected void Raise(DomainEvent domainEvent)
    { 
        _domainEvents.Add(domainEvent);
    }
}
