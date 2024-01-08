using System.ComponentModel.DataAnnotations;

namespace av_api.Models
{
    public class Destinos
    {
        [Key]
        public int IdDestino { get; set; }
        public string cepDestino { get; set; }
        public string nomeDestino { get; set; }
        public double valorPassagem { get; set; }

    }
}
