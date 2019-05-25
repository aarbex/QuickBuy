using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyDominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagem("Nome do produto não informado!");
            }
            if(string.IsNullOrEmpty(Descricao))
            {
                AdicionarMensagem("Descrição do produto não informada!");
            }
            if(Preco <= 0)
            {
                AdicionarMensagem("Preço do produto deve ser maior do que zero!");
            }
        }
    }
}
