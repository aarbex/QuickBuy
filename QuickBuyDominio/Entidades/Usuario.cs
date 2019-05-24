﻿using System.Collections.Generic;

namespace QuickBuyDominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarMensagem("Email não foi informado!");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarMensagem("Senha não informada!")
            }
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagem("Nome não informada!")
            }
            if (string.IsNullOrEmpty(Sobrenome))
            {
                AdicionarMensagem("Sobrenome não informada!")
            }
        }
    }
}
