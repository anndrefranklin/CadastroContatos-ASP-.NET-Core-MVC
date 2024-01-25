using CadastroContatos.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroContatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Usuário")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Login do Usuário")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o Email do Usuário")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido !")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o Perfil do Usuário")]
        public PerfilEnum? Perfil { get; set; }

    }
}
