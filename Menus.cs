using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDeSeries
{
    partial class Program
    {
        static void TelaPrincipal()
        {

            Console.Write("BEM-VINDO AO BANCO DE SÉRIES! " +
                                  "O QUE DESEJA FAZER?\n\n" +
                                  "1 - Pesquisar\n" +
                                  "2 - Cadastrar\n" +
                                  "3 - Sair\n\n" +
                                  "-> ");

            int escolha = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (escolha)
            {
                case 1:
                    TelaPesquisa();
                    break;

                case 2:
                    TelaCadastro();
                    break;

                case 3:
                    sair = true;
                    break;

                default:
                    Console.WriteLine("A opção escolhida não é válida.\n");
                    break;
            }
        }

        static void TelaPesquisa()
        {
            bool voltar = false;

            while (!voltar)
            {
                Console.Write("---PESQUISAR---\n\n" +
                                  "1 - Listas\n" +
                                  "2 - Pesquisar por nome\n" +
                                  "3 - Pesquisar por filtros\n" +
                                  "4 - Voltar\n\n" +
                                  "-> ");

                int escolha = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (escolha)
                {
                    case 1:
                        TelaListar();
                        break;

                    case 2:
                        TelaPesquisarPorNome();
                        break;
                    case 3:
                        TelaFiltrar();
                        break;
                    case 4:
                        voltar = true;
                        break;

                    default:
                        Console.WriteLine("A opção escolhida não é válida.\n");
                        break;
                }
            }
        }

        static void TelaPesquisarPorNome()
        {
            bool voltar = false;

            while (!voltar)
            {
                Console.Write("---PESQUISAR POR NOME---\n\n" +
                                  "1 - Série\n" +
                                  "2 - Ator\n" +
                                  "3 - Criador\n" +
                                  "4 - Emissora\n" +
                                  "5 - Voltar\n\n" +
                                  "-> ");

                int escolha = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                string nome;

                switch (escolha)
                {
                    case 1:
                        Console.Write("--PESQUISAR SÉRIE POR NOME--\n\n" +
                                          "Digite o nome da SÉRIE -> ");
                        nome = Console.ReadLine();
                        PesquisarSerie(nome);
                        break;

                    case 2:
                        Console.Write("--PESQUISAR ATOR POR NOME--\n\n" +
                                          "Digite o nome dO ATOR/ATRIZ -> ");
                        nome = Console.ReadLine();
                        PesquisarAtor(nome);
                        break;
                    case 3:
                        Console.Write("--PESQUISAR CRIADOR POR NOME--\n\n" +
                                          "Digite o nome do CRIADOR -> ");
                        nome = Console.ReadLine();
                        PesquisarCriador(nome);
                        break;
                    case 4:
                        Console.Write("--PESQUISAR EMISSORA POR NOME--\n\n" +
                                          "Digite o nome da EMISSORA -> ");
                        nome = Console.ReadLine();
                        PesquisarEmissora(nome);
                        break;

                    case 5:
                        voltar = true;
                        break;

                    default:
                        Console.WriteLine("A opção escolhida não é válida.\n");
                        break;
                }

                if (!voltar)
                {
                    Console.WriteLine($" --Pressione qualquer tecla para continuar...\n");

                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void TelaListar()
        {
            bool voltar = false;

            while (!voltar)
            {
                Console.Write("---LISTAR TODOS---\n\n" +
                                  "1 - Séries\n" +
                                  "2 - Atores\n" +
                                  "3 - Criadores\n" +
                                  "4 - Emissoras\n" +
                                  "5 - Gêneros \n" +
                                  "6 - Voltar\n\n" +
                                  "-> ");

                int escolha = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (escolha)
                {
                    case 1:
                        ExibirSeries();
                        break;

                    case 2:
                        ExibirAtores();
                        break;

                    case 3:
                        ExibirCriadores();
                        break;

                    case 4:
                        ExibirEmissoras();
                        break;

                    case 5:
                        ExibirGeneros();
                        break;

                    case 6:
                        voltar = true;
                        break;
                    default:
                        Console.WriteLine("A opção escolhida não é válida.\n");
                        break;
                }
            }
        }
        private static void TelaFiltrar()
        {
            bool voltar = false;

            while (!voltar)
            {
                Console.Write("---FILTROS---\n\n" +
                                  "1 - Atores por sexo\n" +
                                  "2 - Serie por quantidade de episódios (EM BREVE)\n" +
                                  "3 - Voltar\n\n" +
                                  "-> ");

                int escolha = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (escolha)
                {
                    case 1:
                        string sexo = "A";
                        while (sexo != "M" && sexo != "F")
                        {
                            Console.WriteLine("--FILTRAR ATORES POR SEXO--");
                            Console.Write("Sexo [M/F] -> ");
                            sexo = Console.ReadLine().ToUpper();
                        }

                        FiltrarAtoresPorSexo(sexo);
                            
                        break;

                    case 2:
                        //FiltrarSeriePorQuantidadeEpisodios();
                        break;

                    case 3:
                        voltar = true; 
                        break;

                    default:
                        Console.WriteLine("A opção escolhida não é válida.\n");
                        break;
                }
            }
        }
        static void TelaCadastro()
        {
            bool voltar = false;

            while (!voltar)
            {
                Console.Write("---CADASTRAR---\n\n" +
                                  "1 - Série\n" +
                                  "2 - Ator\n" +
                                  "3 - Criador\n" +
                                  "4 - Emissora\n" +
                                  "5 - Gênero\n" +
                                  "6 - Voltar\n\n" +
                                  "-> ");

                int escolha = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (escolha)
                {
                    case 1:
                        CadastrarSerie();
                        break;

                    case 2:
                        CadastrarAtor();
                        break;

                    case 3:
                        CadastrarCriador();
                        break;

                    case 4:
                        CadastrarEmissora();
                        break;

                    case 5:
                        CadastrarGenero();
                        break;

                    case 6:
                        voltar = true;
                        break;
                    default:
                        Console.WriteLine("A opção escolhida não é válida.\n");
                        break;
                }
            }
        }

        static string TipoSort(string[] objeto1)
        {
            bool voltar = false;
            string resposta = "";

            while (!voltar)
            {
                Console.Write("---ESCOLHA O TIPO DE SORT---\n\n" +
                                  "1 - Bubble Sort\n" +
                                  "2 - Insertion Sort\n" +
                                  "3 - Shell Sort\n" +
                                  "4 - Quick Sort\n" +
                                  "5 - Voltar\n\n" +
                                  "-> ");

                int escolha = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                string metodo = "nenhum";

                DateTime inicio = DateTime.Now;

                string[] objeto = (string[]) objeto1.Clone();

                switch (escolha)
                {
                    case 1:
                        BubbleSort(objeto);
                        metodo = "Bubble Sort";
                        break;

                    case 2:
                        InsertionSort(objeto);
                        metodo = "Insertion Sort";

                        break;

                    case 3:
                        metodo = "Shell Sort";

                        ShellSort(objeto, objeto.Length);
                        break;

                    case 4:
                        metodo = "Quick Sort";

                        QuickSort(objeto);
                        break;

                    case 5:
                        voltar = true;
                        break;

                    default:
                        Console.WriteLine("A opção escolhida não é válida.\n");
                        break;
                }

                if (voltar)
                    break;

                DateTime fim = DateTime.Now;

                TimeSpan intervalo = fim - inicio;
                double tempo = intervalo.TotalMilliseconds;

                resposta = $"\nMétodo: {metodo}\n" +
                    $"Tempo de Execução: {tempo} milissegundos\n";

                voltar = true;
            }

            return resposta;
        }
    }
}
