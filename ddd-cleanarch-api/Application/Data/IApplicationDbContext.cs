
using Domain.Customer;
using Microsoft.EntityFrameworkCore;

namespace Application.Data;

/// <summary>
/// With this implementation we will have the possibility to implement 
/// X database engine and have its methods abstracted to use them.
/// </summary>
public interface IApplicationDbContext
{
    DbSet<Customer> Customers { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
