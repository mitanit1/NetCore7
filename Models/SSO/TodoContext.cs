using Microsoft.EntityFrameworkCore;

namespace NetCore7.Models.SSO
{
    public class Sso_DbContext : DbContext
    {
        public Sso_DbContext(DbContextOptions<Sso_DbContext> options)
        : base(options)
        {
        }

        public DbSet<Vie_Sso_Acct_Public> vie_Sso_Acct_Publics { get; set; } = null!;
        public DbSet<Vie_Factory> vie_Factories { get; set; } = null!;
    }
}
