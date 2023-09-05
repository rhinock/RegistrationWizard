using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using RegistrationWizard.Models;
using RegistrationWizard.Configuration;

namespace RegistrationWizard.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new CountryConfiguration());
        builder.ApplyConfiguration(new ProvinceConfiguration());
    }

    public DbSet<Country> Countries { get; set; } = null!;
    public DbSet<Province> Provinces { get; set; } = null!;
}
