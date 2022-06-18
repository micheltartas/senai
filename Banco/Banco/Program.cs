using System;
using Banco.Contexto;
using Banco.Entidades;
using Banco.Migrations;

private static SenaiContext _context;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _context = new SenaiContext();
            ChamarMenu();
        }

        private static void ChamarMenu()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Cadastrar uma Escola");
            Console.WriteLine("2 - Cadastrar um Professor");
            Console.WriteLine("3 - Cadastrar uma Classe");
            Console.WriteLine("4 - Cadastrar um Aluno");
            Console.WriteLine("5 - Listar Alunos");
            Console.WriteLine("6 - Excluir Aluno");
            var escolhaMenu = Console.ReadLine();
            ExecutarEscolha(escolhaMenu);
        }

        private static void ApresentarErro()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Menu Inválido");
            Console.ResetColor();
            ChamarMenu();
        }

        private static void CadastrarEscola()
        {
            var escola = new Escola();
            var endereco = new Endereco();

            Console.WriteLine("Digite o Nome da Escola: ");
            escola.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Rua da Escola");
            endereco.Rua = Console.ReadLine();

            Console.WriteLine("Digite o Bairro da Escola");
            endereco.Bairro = Console.ReadLine();

            Console.WriteLine("Digite a Cidade da Escola");
            endereco.Cidade = Console.ReadLine();

            Console.WriteLine("Digite o Estado da Escola");
            endereco.Estado = Console.ReadLine();

            Console.WriteLine("Digite o Número do Endereço da Escola");
            endereco.Numero = Convert.ToInt16(Console.ReadLine());

            escola.Endereco = endereco;
            SalvarEscola(escola);
        }

        private static void SalvarEscola(Escola escola)
        {
            _context.Escola.Add(escola);
            _context.SaveChanges();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Escola Salva com Sucesso");
            Console.ResetColor();
            ChamarMenu();
        }

        private static void CadastrarProfessor()
        {
            
        }

        private static void CadastrarClasse()
        {

        }

        private static void CadastrarAluno()
        {

        }

        private static void ListarAluno()
        {

        }

        private static void ExcluirAluno()
        {

        }

        private static void ListarEscola()
        {
            var escola = _context.Escola.ToList();
        }

        private static void ExecutarEscolha(string escolhaMenu)
        {
            switch (escolhaMenu)
            {
                case "1": CadastrarEscola();    break;
                case "2": CadastrarProfessor(); break;
                case "3": CadastrarClasse();    break;
                case "4": CadastrarAluno();     break;
                case "5": ListarAluno();        break;
                case "6": ExcluirAluno();       break;
                default: ApresentarErro();      break;
            }
        }
    }
}
