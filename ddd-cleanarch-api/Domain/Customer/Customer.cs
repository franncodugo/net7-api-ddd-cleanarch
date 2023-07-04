using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Customer;

public sealed class Customer : AggregateRoot
{
    public CustomerId Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string FullName => $"{Name} {LastName}";
    public string Email { get; private set; } = string.Empty;
    public bool Active { get; set; }
    /// <summary>
    /// ValueObject: Contains the logic necessary to create a valid Phone Number.
    /// </summary>
    public PhoneNumber PhoneNumber { get; private set; }
    /// <summary>
    /// ValueObject: Contains the logic necessary to create a valid Address.
    /// </summary>
    public Address Address { get; private set; }

    public Customer(CustomerId id, string name, string lastName, string email, bool active, PhoneNumber phoneNumber, Address address)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
        Active = active;
    }

    // Just for EntityFramework.
    private Customer() { }
}
