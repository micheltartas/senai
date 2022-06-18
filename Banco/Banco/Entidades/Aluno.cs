using System;
using System.ComponentModel.DataAnnotations;

namespace Banco.Entidades { 
    public class Aluno : BaseEntity
    {
        [Required, MaxLength(60)]
        public string Nome { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [Required, MaxLength(14)]
        public String Cpf { get; set; }

        public long ClasseId { get; set; }

        public Classe Classe { get; set; }
         
    }
}
