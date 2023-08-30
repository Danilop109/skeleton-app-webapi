using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Persistencia.Data.Configuration;
    public class PersonaConfiguration: IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona");

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Genero)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdGeneroFk);
            
            builder.HasOne(p => p.Ciudad)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdCiudadFk);

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTipoPersonaFk);
        }
    }
