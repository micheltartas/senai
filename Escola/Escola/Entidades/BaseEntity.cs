using System.ComponentModel.DataAnnotations;

namespace Escola.Entidades
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
