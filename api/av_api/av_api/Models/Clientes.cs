using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace av_api.Models
{
    public class Clientes
    {
        [Key]
        public int idCliente { get; set; }
        [Required(ErrorMessage ="Nome é obrigatorio")]
        [MaxLength(60,ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(5)]
        public string nome { get; set; }
        [Required(ErrorMessage = "Email é obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(5)]
        public string email { get; set; }
        [Required(ErrorMessage = "Senha é obrigatorio")]
        public string senha { get; set; }

    }
}
