using Microsoft.EntityFrameworkCore;
using TransitoRD.Core.Domain.Common;
using TransitoRD.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TransitoRD.Infrastucture.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Multas> Multa { get; set; }
        public DbSet<MultasTipo> MultasTipo { get; set; }
        public DbSet<Licencia> Licencia { get; set; }
        public DbSet<Vehiculos> Vehiculo { get; set; }
        public DbSet<Agentes> Agente { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Creacion = DateTime.Now;
                        entry.Entity.CreadoPor = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.UltimaModificaio = DateTime.Now;
                        entry.Entity.UltimaModificaionPor = "DefaultAppUser";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API

            #region tables
            modelBuilder.Entity<Multas>()
                .ToTable("Multas");

            modelBuilder.Entity<Vehiculos>()
                .ToTable("Vehiculos");

            modelBuilder.Entity<Agentes>()
                .ToTable("Agentes");

            modelBuilder.Entity<MultasTipo>()
                .ToTable("MultasTipo");

            modelBuilder.Entity<Licencia>()
                .ToTable("Licencia");
            #endregion

            #region "primary keys"
            modelBuilder.Entity<Multas>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Vehiculos>()
               .HasKey(p => p.Id);

            modelBuilder.Entity<Agentes>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<MultasTipo>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Licencia>()
               .HasKey(f => f.Id);

            #endregion

            #region "Relationships"

            modelBuilder.Entity<Agentes>()
            .HasMany<Multas>(f => f.multas)
            .WithOne(P => P.Agente)
            .HasForeignKey(p => p.AgenteId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MultasTipo>()
            .HasMany<Multas>(f => f.multas)
            .WithOne(P => P.MultasTipo)
            .HasForeignKey(p => p.CodigoMulta)
            .OnDelete(DeleteBehavior.Cascade);


            #endregion

            #region "Property configurations"

            #region Multas

            modelBuilder.Entity<Multas>().
                Property(p => p.AgenteId)
                .IsRequired();

            modelBuilder.Entity<Multas>().
                Property(p => p.CodigoMulta)
                .IsRequired();

            modelBuilder.Entity<Multas>().
               Property(p => p.Cedula_infractor)
               .IsRequired();

            modelBuilder.Entity<Multas>().
               Property(p => p.Placa_Vehiculo)
               .IsRequired();

            #endregion

            #region FotMultasTipoos
           

            modelBuilder.Entity<MultasTipo>().
             Property(c => c.CodigoMulta)
             .IsRequired();

            modelBuilder.Entity<MultasTipo>().
            Property(c => c.descripcion)
            .IsRequired();
            #endregion

            #region Agentes
           
            modelBuilder.Entity<Agentes>().
             Property(c => c.nombre)
             .IsRequired();
            modelBuilder.Entity<Agentes>().
             Property(c => c.apellido)
             .IsRequired();
            modelBuilder.Entity<Agentes>().
             Property(c => c.cedula)
             .IsRequired();
            modelBuilder.Entity<Agentes>().
             Property(c => c.estatus)
             .IsRequired();


            #endregion

            #region Licencia
            modelBuilder.Entity<Licencia>().
              Property(c => c.Nombre)
              .IsRequired();

            modelBuilder.Entity<Licencia>().
             Property(c => c.Apellido)
             .IsRequired();

              modelBuilder.Entity<Licencia>().
             Property(c => c.Cedula)
             .IsRequired();

            modelBuilder.Entity<Licencia>().
            Property(c => c.Fecha_Nacimiento)
            .IsRequired();

            modelBuilder.Entity<Licencia>().
            Property(c => c.Foto)
            .IsRequired();

            modelBuilder.Entity<Licencia>().
            Property(c => c.Direccion)
            .IsRequired();

            modelBuilder.Entity<Licencia>().
            Property(c => c.Telefono)
            .IsRequired();
            #endregion

            #region Vehiculos
            modelBuilder.Entity<Vehiculos>().
              Property(c => c.Placa)
              .IsRequired();

            modelBuilder.Entity<Vehiculos>().
             Property(c => c.Chasis)
             .IsRequired();

            modelBuilder.Entity<Vehiculos>().
              Property(c => c.Marca)
              .IsRequired();

            modelBuilder.Entity<Vehiculos>().
              Property(c => c.Modelo)
              .IsRequired();
            modelBuilder.Entity<Vehiculos>().
              Property(c => c.Fabricacion)
              .IsRequired();
            modelBuilder.Entity<Vehiculos>().
              Property(c => c.Color);

              modelBuilder.Entity<Vehiculos>().
              Property(c => c.Pasajeros)
              .IsRequired();

            modelBuilder.Entity<Vehiculos>().
              Property(c => c.Cedula_Propietario)
              .IsRequired();
            modelBuilder.Entity<Vehiculos>().
              Property(c => c.Direccion_Propietario)
              .IsRequired();
            modelBuilder.Entity<Vehiculos>().
              Property(c => c.Nombre_Propietario)
              .IsRequired();

            #endregion

            #endregion

        }

    }
}
