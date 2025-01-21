using ClickBonus_API.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ClickBonus_API.Context;

public partial class ClickBonusContext : DbContext
{
    public ClickBonusContext()
    {
    }

    public ClickBonusContext(DbContextOptions<ClickBonusContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Oferta> Ofertas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Oferta>()
            .Property(o => o.DataCriacao)
            .HasDefaultValueSql("getdate()");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
}