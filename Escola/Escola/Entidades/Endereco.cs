namespace Escola.Entidades
{
    public class Endereco : BaseEntity
    {
        public string Rua { get; set; }

        public string Bairro { get; set; }

        public int Numero { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public long ColegioId { get; set; }

        public Colegio Colegio { get; set; }
    }
}
