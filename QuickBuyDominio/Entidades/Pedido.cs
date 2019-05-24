using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyDominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public Usuario UsuarioId { get; set; }

        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}
