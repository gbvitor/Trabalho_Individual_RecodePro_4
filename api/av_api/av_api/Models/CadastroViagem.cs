using System.ComponentModel.DataAnnotations;

namespace av_api.Models
{
    public class CadastroViagem
    {
        [Key]
        public int idCadastro {  get; set; }

        public Clientes clientes { get; set; }

        public Destinos destinos { get; set; }
    }
}
