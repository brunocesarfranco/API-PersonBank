using System.ComponentModel.DataAnnotations;

namespace PersonBank.API.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Esse campo é obrigario")]
        [MinLength(3, ErrorMessage = "Seu nome deve conter no minimo 3 caracteres")]
        [MaxLength(30, ErrorMessage = "Seu nome deve conter no maximo 30 caracteres")]
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }

    }
}
