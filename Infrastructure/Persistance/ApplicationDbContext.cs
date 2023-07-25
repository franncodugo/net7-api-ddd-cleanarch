using Application.Data;
using Domain.Customer;
using Domain.Primitives;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance;

public class ApplicationDbContext : DbContext, IApplicationDbContext, IUnitOfWork
{
    /// <summary>
    /// Used to publish the DomainEvents.
    /// </summary>
    private readonly IPublisher _publisher;

    public ApplicationDbContext(DbContextOptions options, IPublisher publisher)
        :base(options)
    {
        _publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));
    }

    public DbSet<Customer> Customers { get; set; }

    // We must collect by means of (AggregateRoot) all the DomainEvents that will be given
    // by the saving of information.
    // And we will do it every time the SaveChangesAsync() method is executed.
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        return 1;
    }


}
