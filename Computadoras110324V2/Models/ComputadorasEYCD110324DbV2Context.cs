using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Computadoras110324V2.Models
{
    public partial class ComputadorasEYCD110324DbV2Context : DbContext
    {
        public ComputadorasEYCD110324DbV2Context()
        {
        }

        public ComputadorasEYCD110324DbV2Context(DbContextOptions<ComputadorasEYCD110324DbV2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Componente> Componentes { get; set; } = null!;
        public virtual DbSet<Computadora> Computadoras { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ComputadorasEYCD110324DbV2;Integrated Security=True;Encrypt=False");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Componente>(entity =>
            {
                entity.Property(e => e.AlmacenamientoGb).HasColumnName("AlmacenamientoGB");

                entity.Property(e => e.MemoriaRamgb).HasColumnName("MemoriaRAMGB");

                entity.Property(e => e.Procesador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdComputadorasNavigation)
                    .WithMany(p => p.Componente)
                    .HasForeignKey(d => d.IdComputadoras)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Component__IdCom__398D8EEE");
            });

            modelBuilder.Entity<Computadora>(entity =>
            {
                entity.Property(e => e.FechaLlegada).HasColumnType("date");

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
