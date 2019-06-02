using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuyDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyRepositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(400);

            builder.Property(p => p.Preco)
                .IsRequired();
        }
    }
}
