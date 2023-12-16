using Microsoft.EntityFrameworkCore;
using Notificator.Models;

namespace Notificator.DAL;

public class SubscriptionDbContext : DbContext
{
    public SubscriptionDbContext(DbContextOptions<SubscriptionDbContext> options) : base(options)
    {
    }

    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<Subscriber> Subscribers { get; set; }
}