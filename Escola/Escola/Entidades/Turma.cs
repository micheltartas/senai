using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Escola.Entidades.Enums;

namespace Escola.Entidades
{
    public class Turma : BaseEntity
    {
        [Required, MaxLength(80)]
        public string Nome { get; set; }

        public Serie Serie { get; set; }

        public Turno Turno { get; set; }

        public long ProfessorId { get; set; }

        public Professor Professor { get; set; }

        public List<Aluno> Alunos { get; set; }

    }
}
