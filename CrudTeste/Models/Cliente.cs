using System.ComponentModel.DataAnnotations;

namespace CrudTeste.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Data obrigatória")]  
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }
        [Required(ErrorMessage = "CPF obrigatório")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "E-mail obrigatório")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Email obrigatório")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string ConfirmaEmail { get; set; }
        [Required(ErrorMessage = "Nome do usuário obrigatório")]
        public string NomeUsuario { get; set; }
        [Required(ErrorMessage = "Telefone obrigatório")]
        [Phone(ErrorMessage = "Telefone inválido")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Senha obrigatória")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Senha obrigatória")]
        [DataType(DataType.Password)]
        public string ConfirmaSenha { get; set; }

    }
}
