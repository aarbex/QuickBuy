using QuickBuyDominio.Entidades;
using QuickBuyRepositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyRepositorio
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var usuario = new Usuario();
            usuarioRepositorio.Adicionar(usuario);
        }
    }
}
