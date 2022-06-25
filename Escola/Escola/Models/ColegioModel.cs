using System.ComponentModel.DataAnnotations;

namespace Escola.Models
{
    public class ColegioModel
    {
        [Required, MaxLength(80)]
        public string Nome { get; set; }
    }
}
