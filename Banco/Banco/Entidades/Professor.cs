using System;
using System.ComponentModel.DataAnnotations;

namespace Banco.Entidades
{
	public class Professor : BaseEntity
	{
		[Required, MaxLength(80)]
		public string Nome { get; set; }

		public long EscolaId { get; set; }

		public Escola Escola { get; set; }

		public Classe Classe { get; set; }


	}
}
