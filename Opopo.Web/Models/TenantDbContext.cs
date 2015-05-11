using System;
using System.Data.Entity;

namespace Opopo.Web.Models
{
    public class TenantDbContext : DbContext
    {
        public TenantDbContext()
            : base("OpopoConnection")
        {
        }

        public DbSet<IssuingAuthorityKey> IssuingAuthorityKeys { get; set; }

        public DbSet<Tenant> Tenants { get; set; }
    }
}