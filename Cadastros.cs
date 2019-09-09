using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace BancoDeSeries
{
    partial class Program
    {
        static void CadastrarSerie()
        {
            Console.WriteLine("---CADASTRAR SÉRIE---\n");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Quantidade de Episódios: ");
            string qnteps = Console.ReadLine();
            Console.Write("Ano de Início: ");
            string anoInicio = Console.ReadLine();
            Console.Write("Ano de Fim: ");
            string anoFim = Console.ReadLine();
            Console.Write("Gêneros: ");
            string generos = Console.ReadLine();
            Console.Write("Criadores: ");
            string criadores = Console.ReadLine();
            Console.Write("Emissoras: ");
            string emissoras = Console.ReadLine();
            Console.Write("Atores: ");
            string atores = Console.ReadLine();

            string linha = $"{nome};{qnteps};{anoInicio};{anoFim};{generos};{criadores};{emissoras};{atores};";

            EscreverNoArquivo("serie", linha);

            Console.Clear();

            Console.WriteLine("SÉRIE CADASTRADA COM SUCESSO!\n\n");
        }

        static void CadastrarAtor()
        {
            Console.WriteLine("---CADASTRAR ATOR---\n");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            string idade = Console.ReadLine();
            Console.Write("Sexo: ");
            string sexo = Console.ReadLine();

            string linha = $"{nome};{idade};{sexo};";

            EscreverNoArquivo("ator", linha);
        }

        static void CadastrarGenero()
        {
            Console.WriteLine("---CADASTRAR GÊNERO---\n");
            Console.Write("Categoria: ");
            string categoria = Console.ReadLine();
            
            string linha = $"{categoria};";
            EscreverNoArquivo("genero", linha);

            Console.Clear();

            Console.WriteLine("GÊNERO CADASTRADO COM SUCESSO!\n\n");
        }

        static void CadastrarEmissora()
        {
            Console.WriteLine("---CADASTRAR EMISSORA---\n");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("País: ");
            string pais = Console.ReadLine();
            
            string linha = $"{nome};{pais};";
            EscreverNoArquivo("emissora", linha);

            Console.Clear();

            Console.WriteLine("EMISSORA CADASTRADA COM SUCESSO!\n\n");
        }

        static void CadastrarCriador()
        {
            Console.WriteLine("---CADASTRAR CRIADOR---\n");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            string idade = Console.ReadLine();
            Console.Write("Sexo: ");
            string sexo = Console.ReadLine();

            string linha = $"{nome};{idade};{sexo};";
            EscreverNoArquivo("criador", linha);

            Console.Clear();

            Console.WriteLine("CRIADOR CADASTRADO COM SUCESSO!\n\n");
        }

        static void EscreverNoArquivo(string nomeArquivo, string linha)
        {
            string arquivo = $"{nomeArquivo}.csv";

            using (StreamWriter sr = File.AppendText(arquivo))
            {
                sr.WriteLine(linha);
            }
        }
    }
}
