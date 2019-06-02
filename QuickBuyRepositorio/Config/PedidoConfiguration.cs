using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuyDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyRepositorio.Config
{
    class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Cep)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(400);

            builder.Property(p => p.DataPedido)
                .IsRequired();

            builder.Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            builder.Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(400);

            builder.Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(20);

            builder.Ignore(p => p.FormaPagamento);

            builder.Property(p => p.FormaPagamentoId)
                .IsRequired();

            builder.Ignore(p => p.ItensPedidos);

            builder.Property(p => p.NumeroEndereco)
                .IsRequired();

            builder.Property(p => p.UsuarioId)
                .IsRequired();
        }
    }
}
