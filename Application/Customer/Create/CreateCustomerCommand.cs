using MediatR;

namespace Application.Customer.Create;

internal record CreateCustomerCommand(
    string Name,
    string LastName,
    string Email, 
    bool Active,
    string PhoneNumber,
    string Coutry,
    string Line1,
    string Line2,
    string City,
    string State,
    string ZipCode) : IRequest<Unit>;
