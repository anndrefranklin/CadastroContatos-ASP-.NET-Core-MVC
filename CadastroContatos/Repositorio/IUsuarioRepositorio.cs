﻿using CadastroContatos.Models;
using System.Collections.Generic;

namespace CadastroContatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ListarPorId(int id);

        List<UsuarioModel> BuscarTodos();
        
        UsuarioModel Adicionar(UsuarioModel usuario);
        
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
