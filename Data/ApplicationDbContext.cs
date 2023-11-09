using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace POSTO_ERP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal object Contexto;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}