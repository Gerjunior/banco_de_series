using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BancoDeSeries
{
    partial class Program
    {
        static void ExibirSeries()
        {
            LerArquivo("serie");
        }

        static void ExibirAtores()
        {
            LerArquivo("ator");
        }

        static void ExibirCriadores()
        {
            LerArquivo("criador");
        }

        static void ExibirEmissoras()
        {
            LerArquivo("emissora");
        }

        static void ExibirGeneros()
        {
            LerArquivo("genero");
        }

        static void LerArquivo(string caminho)
        {
            string arquivo = $"{caminho}.csv";

            int linhas = File.ReadLines(arquivo).Count();

            string[] todos = new string[linhas];

            using (StreamReader reader = new StreamReader(File.OpenRead(arquivo)))
            {
                string linha;
                int l = 0;
                reader.ReadLine();
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] lista = linha.Split(";");
                    todos[l] = lista[0];
                    l++;
                }
            }

            string tempo = TipoSort(todos);

            Console.WriteLine($"--LISTA DE {caminho.ToUpper()}S---\n\n");

            int pos = 0;
            foreach (string item in todos)
            {
                if (pos == 0)
                {
                    pos++;
                    continue;
                }

                Console.WriteLine(pos + " - " + item);
                pos++;
            }

            Console.WriteLine(tempo);

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();

            Console.Clear();
        }
    }
}
