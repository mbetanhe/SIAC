using Microsoft.EntityFrameworkCore;
using SIAC.CORE.Entities;
using SIAC.CORE.Entities.Premisas;
using System.Reflection;

#nullable disable

namespace SIAC.INFRASTRUCTURE.Data
{
    public partial class AuditoriaDeCampoContext : DbContext
    {
        public AuditoriaDeCampoContext()
        {
        }

        public AuditoriaDeCampoContext(DbContextOptions<AuditoriaDeCampoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DimParametro> DimParametros { get; set; }
        public virtual DbSet<FacPremisasOffline> FacPremisasOfflines { get; set; }
        public virtual DbSet<ParamAuditPremOff> ParamAuditPremOffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
