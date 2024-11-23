using Abp.Zero.EntityFrameworkCore;
using Abp.React.Authorization.Roles;
using Abp.React.Authorization.Users;
using Abp.React.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Abp.React.EntityFrameworkCore;

public class ReactDbContext : AbpZeroDbContext<Tenant, Role, User, ReactDbContext>
{
    /* Define a DbSet for each entity of the application */

    public ReactDbContext(DbContextOptions<ReactDbContext> options)
        : base(options)
    {
    }
}
