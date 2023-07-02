using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Customer;

public sealed class Customer : AggregateRoot
{
    public Customer(CustomerId id, string name, string lastName, string email, PhoneNumber phoneNumber, Address address, bool active)
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

    public CustomerId Id { get; private set; }    
    public string Name { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string FullName => $"{Name} {LastName}";
    public string Email { get; private set; } = string.Empty;

    /// <summary>
    /// ValueObject: Contains the logic necessary to create a valid phone number.
    /// </summary>
    public PhoneNumber PhoneNumber { get; private set; }

    /// <summary>
    /// ValueObject: Contains the logic necessary to create a valid phone number.
    /// </summary>
    public Address Address { get; private set; }
    public bool Active { get ; set; }
}
