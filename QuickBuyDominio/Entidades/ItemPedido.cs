﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyDominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
            {
                AdicionarMensagem("Não foi identificada a referÊncia do produto!");
            }
            if (Quantidade == 0)
            {
                AdicionarMensagem("Quantidade não foi informada!");
            }
        }
    }
}
