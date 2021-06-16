using System;

namespace DIO.Series
{
    public static class MenuPrincipal 
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        public static void ListarSeries()
        {
            Console.WriteLine("Listar Series");

            var lista  = repositorio.Lista();

            if(lista.Count <= 0)
            {
                Console.WriteLine("Nenhuma lista cadastrada.");
                return;
            }
            else
            {
                foreach(Serie serie in lista)
                {
                    if(serie.RetornaExcluido() == false)
                    {
                        Console.WriteLine("#ID {0} : {1} ", serie.RetornaId(), serie.RetornaTitulo());
                    }    
                }
            }
        }        

        public static void InserirSerie()
        {
            Console.WriteLine("Inserir Nova Serie.");

            foreach(int i in Enum.GetValues(typeof(Generos)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Generos), i));
            }
            Console.Write("Digite um Genero pelo ID: ");
            int escolhaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite uma Descrição para a Serie: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite o Ano da Serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Serie novaSerie = new Serie(repositorio.ProximoId(), 
                                        (Generos)escolhaGenero,
                                        entradaTitulo,
                                        entradaDescricao,
                                        entradaAno);

            repositorio.Lista().Add(novaSerie);
        }

        public static void AtualizarSerie()
        {
            var lista = repositorio.Lista();            
            
            if(lista.Count > 0)
            {
                ListarSeries();
                Console.Write("Escolha a Serie para ser atualizada: ");
                int serieEscolhida = int.Parse(Console.ReadLine());

                for (int y = 0; y < lista.Count; y++)
                {
                    if(lista[y] == null || lista[y].RetornaExcluido() == true)
                    {
                        Console.WriteLine("Serie nâo encontrada.");
                        return;
                    }
                    else
                    {
                        lista[y].ToString();

                        Console.WriteLine("Inserir Nova Serie.");

                        foreach(int i in Enum.GetValues(typeof(Generos)))
                        {
                            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Generos), i));
                        }
                        Console.Write("Digite um Genero pelo ID: ");
                        int escolhaGenero = int.Parse(Console.ReadLine());

                        Console.Write("Digite o Titulo da Serie: ");
                        string entradaTitulo = Console.ReadLine();

                        Console.Write("Digite uma Descrição para a Serie: ");
                        string entradaDescricao = Console.ReadLine();

                        Console.Write("Digite o Ano da Serie: ");
                        int entradaAno = int.Parse(Console.ReadLine());

                        Serie novaSerie = new Serie(repositorio.ProximoId(), 
                                                    (Generos)escolhaGenero,
                                                    entradaTitulo,
                                                    entradaDescricao,
                                                    entradaAno);

                        lista[y] = novaSerie;

                        Console.WriteLine("Serie Atualizada.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Sem Series para atualizar.");
                return;
            }
        }

        public static void ExcluirSerie()
        {
            var lista = repositorio.Lista();

            if(lista.Count > 0)
            {
                ListarSeries();
                Console.Write("Escolha a Serie para ser excluir: ");
                int serieEscolhida = int.Parse(Console.ReadLine());

                for (int y = 0; y < lista.Count; y++)
                {
                    if(lista[y] == null || lista[y].RetornaExcluido() == true)
                    {
                        Console.WriteLine("Serie nâo encontrada.");
                        return;
                    }
                    else
                    {
                        lista[y].ToString();

                        Console.Write("Tem Certeza ?(S/N): ");
                        string decisao = Console.ReadLine().ToUpper();

                        while(decisao != "S" || decisao != "N")
                        {
                            Console.Write("Tem Certeza ?(S/N): ");
                            decisao = Console.ReadLine().ToUpper();
                        }

                        if(decisao == "N")
                        {
                            return;
                        }
                        else
                        {
                            lista[y].Excluir();
                            Console.WriteLine("Serie Excluida.");
                        }                        
                    }
                }
            }
            else
            {
                Console.WriteLine("Sem Series para Excluir.");
                return;
            }
        }

        public static void VisualizarSerie()
        {
            var lista = repositorio.Lista();

            if(lista.Count > 0)
            {
                ListarSeries();
                Console.Write("Escolha a Serie para ser Visualizar: ");
                int serieEscolhida = int.Parse(Console.ReadLine());

                for (int y = 0; y < lista.Count; y++)
                {
                    if(lista[y] == null || lista[y].RetornaExcluido() == true)
                    {
                        Console.WriteLine("Serie nâo encontrada.");
                        return;
                    }
                    else
                    {
                        lista[y].ToString();
                        Console.WriteLine("Pressione qualquer tecla para sair");
                    }
                }
            }
            else
            {
                Console.WriteLine("Sem Series para Visualizar.");
                return;
            }
        }
    }
}