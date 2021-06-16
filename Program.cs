using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {                
                Escolha(opcaoUsuario);
                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Hello World!");
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("\nDIO Séries a seu dispor !!");
            Console.WriteLine("Informe a opção desejada.\n");

            Console.WriteLine("1 - Listar Series.");
            Console.WriteLine("2 - Inserir Nova Serie.");
            Console.WriteLine("3 - Atualizar Serie.");
            Console.WriteLine("4 - Excluir Serie.");
            Console.WriteLine("5 - Visualizar Serie.");
            Console.WriteLine("C - Limpar Tela.");
            Console.WriteLine("X - Sair./n");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        } 

        private static void Escolha(string opcao)
        {
            switch(opcao)
            {
                case "1":
                    MenuPrincipal.ListarSeries();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "2":
                    MenuPrincipal.InserirSerie();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "3":
                    MenuPrincipal.AtualizarSerie();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "4":
                    MenuPrincipal.ExcluirSerie();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "5":
                    MenuPrincipal.VisualizarSerie();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "C":
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Opção Invalida.");
                    Console.Clear();
                    break;
            }
        }
    }
}
