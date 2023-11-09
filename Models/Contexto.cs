using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace POSTO_ERP.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<CLIENTES> Cliente { get; set; }
    }
}
