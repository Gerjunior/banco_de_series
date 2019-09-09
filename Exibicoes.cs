using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BancoDeSeries
{
    partial class Program
    {
        static void PesquisarSerie(string nome)
        {
            Console.Clear();

            string retorno = ProcurarPorAlgoNoArquivo("serie", nome);

            if (retorno == "")
            {
                Console.WriteLine($"'{nome}' não está cadastrada no sistema.");
                return;
            }

            string[] serie = retorno.Split(";");
            Console.WriteLine($"--{serie[0].ToUpper()}--\n\n" +
                              $"Quantidade de Episódios Exibidos: {serie[1]}\n" +
                              $"Ano de Início: {serie[2]}\n" +
                              $"Ano de Fim: {serie[3]}\n" +
                              $"Gêneros: {serie[4]}\n" +
                              $"Criadores: {serie[5]}\n" +
                              $"Emissoras: {serie[6]}\n" +
                              $"Protagonista: {serie[7]}\n\n");
        }

        static void PesquisarAtor(string nome)
        {
            Console.Clear();

            string retorno = ProcurarPorAlgoNoArquivo("ator", nome);

            if (retorno == "")
            {
                Console.WriteLine($"'{nome}' não está cadastrado(a) no sistema.");
                return;
            }

            string[] ator = retorno.Split(";");
            Console.WriteLine($"--{ator[0].ToUpper()}--\n\n" +
                              $"Idade: {ator[1]}\n" +
                              $"Sexo: {ator[2].ToUpper()}\n\n");
        }

        static void PesquisarEmissora(string nome)
        {
            Console.Clear();

            string retorno = ProcurarPorAlgoNoArquivo("emissora", nome);

            if (retorno == "")
            {
                Console.WriteLine($"'{nome}' não está cadastrada no sistema.");
                return;
            }

            string[] emissora = retorno.Split(";");
            Console.WriteLine($"--{emissora[0].ToUpper()}--\n\n" +
                              $"País: {emissora[1]}\n\n");
        }
        static void PesquisarCriador(string nome)
        {
            Console.Clear();

            string retorno = ProcurarPorAlgoNoArquivo("criador", nome);

            if (retorno == "")
            {
                Console.WriteLine($"'{nome}' não está cadastrado(a) no sistema.");
                return;
            }

            string[] criador = retorno.Split(";");
            Console.WriteLine($"--{criador[0].ToUpper()}--\n\n" +
                              $"Idade: {criador[1]}\n" +
                              $"Sexo:: {criador[2]}\n");
        }

        static string ProcurarPorAlgoNoArquivo(string caminho, string nome)
        {
            string arquivo = $"{caminho}.csv";

            List<string> item = new List<string>();

            using (StreamReader reader = new StreamReader(File.OpenRead(arquivo)))
            {
                string linha;
                reader.ReadLine();
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] lista = linha.Split(";");
                    if (lista[0].ToUpper().Contains(nome.ToUpper()))
                    {
                        return linha;
                    }
                }
            }
            return "";
        }
    }
}
