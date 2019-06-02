using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuyDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyRepositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            //Builder utiliza padrão Fluent
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnType("nvarchar");

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
