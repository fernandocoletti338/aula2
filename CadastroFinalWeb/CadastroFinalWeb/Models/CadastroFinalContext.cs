using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CadastroFinalWeb.Models
{
    public partial class CadastroFinalContext : DbContext
    {
        public CadastroFinalContext()
        {
        }

        public CadastroFinalContext(DbContextOptions<CadastroFinalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuarios> Usuarios { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(e => e.EMail)
                    .HasColumnName("E-Mail")
                    .HasMaxLength(50);

                entity.Property(e => e.Login).HasMaxLength(30);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Senha).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
