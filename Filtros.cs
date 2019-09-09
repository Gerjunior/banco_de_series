using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BancoDeSeries
{
    partial class Program
    {
        static void FiltrarAtoresPorSexo(string sexo)
        {
            Console.Clear();

            if (sexo == "M")
            {
                Console.WriteLine("--TODOS OS ATORES--\n");
                FiltrarAtoresPorSexoBackEnd("M");
            }
            else
            {
                Console.WriteLine("--TODAS AS ATRIZES--\n");
                FiltrarAtoresPorSexoBackEnd("F");
            }
        }

        static void FiltrarAtoresPorSexoBackEnd(string sexo)
        {
            string arquivo = "ator.csv";

            List<string> todos = new List<string>();

            using (StreamReader reader = new StreamReader(File.OpenRead(arquivo)))
            {
                string linha;
                reader.ReadLine();
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] lista = linha.Split(";");
                    if (lista[2] == sexo)
                        todos.Add(lista[0]);
                }
            }

            todos.Sort();

            int pos = 1;
            foreach (string item in todos)
            {
                Console.WriteLine(pos + " - " + item);
                pos++;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();

            Console.Clear();
        }

        //static void FiltrarSeriePorQuantidadeEpisodios()
        //{
        //    Console.WriteLine("--FILTRAR SERIES POR QUANTIDADE DE EPISÓDIOS");
        //}
    }
}
