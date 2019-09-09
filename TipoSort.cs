using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDeSeries
{
    partial class Program
    {
        static string[] BubbleSort(string[] objeto)
        {
            for (int i = 0; i < objeto.Length; i++)
            {
                for (int j = i + 1; j < objeto.Length; j++)
                {
                    if (string.Compare(objeto[i], objeto[j]) > 0)
                    {
                        string temp = objeto[i];
                        objeto[i] = objeto[j];
                        objeto[j] = temp;
                    }
                }
            }

            return objeto;
        }

        static string[] InsertionSort(string[] objeto)
        {
            string atual;
            int j;
            for (int i = 0; i < objeto.Length; i++)
            {
                atual = objeto[i];
                j = i;
                while((j > 0) && string.Compare(objeto[j -1], atual) > 0)
                {
                    objeto[j] = objeto[j - 1];
                    j = j - 1;
                }
                objeto[j] = atual;
            }

            return objeto;
        }

        static string[] ShellSort(string[] objeto, int n)
        {
            int pos = 3;
            int j;
            
            while (pos > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    j = i;
                    string temp = objeto[i];

                    while ((j >= pos) && (string.Compare(objeto[j-pos], temp) > 0)){
                        objeto[j] = objeto[j - pos];
                        j = j - pos;
                    }

                    objeto[j] = temp;
                }

                if (pos / 2 != 0)
                    pos = pos / 2;

                else if (pos == 1)
                    pos = 0;

                else
                    pos = 1;
            }

            return objeto;
        }

        static string[] QuickSort(string[] objeto)
        {
            int inicio = 0;
            int fim = objeto.Length - 1;

            QuickSort(objeto, inicio, fim);

            return objeto;
        }

        static string[] QuickSort(string[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                string p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (string.Compare(vetor[i], p) <= 0)
                    {
                        i++;
                    }

                    else if (string.Compare(p, vetor[f]) < 0)
                    {
                        f--;
                    }

                    else
                    {
                        string troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;

                QuickSort(vetor, inicio, f - 1);
                QuickSort(vetor, f + 1, fim);
            }

            return vetor;
        }

        //TENTATIVAS DE ORDENAR O VETOR SEM UTILIZAR O STRING.COMPARE
        //static string[] BubbleSort(string[] objeto)
        //{
        //    //Lista = objeto;
        //    Lista = new string[4] { "Claudio", "Abner", "Aviao", "Elio" };

        //    //for (int i = 0; i < objeto.Length; i++)
        //    for (int i = 0; i < Lista.Length; i++)
        //    {
        //        if (objeto[i] == null)
        //            return objeto;

        //        //for (int j = i+1; j < objeto.Length; j++)
        //        for (int j = i; j < Lista.Length; j++)
        //        {
        //            int pos = 0;

        //            //if (objeto[i][pos] < objeto[j][pos])
        //            if (Lista[i][pos] < Lista[j][pos])
        //                {
        //                Trocar(i, j);
        //                //string temp = objeto[i];
        //                //objeto[i] = objeto[j];
        //                //objeto[j] = temp;
        //                continue;
        //            }

        //            //int menor = objeto[i].Length < objeto[j].Length ? objeto[i].Length : objeto[j].Length;
        //            int menor = Lista[i].Length < Lista[j].Length ? Lista[i].Length : Lista[j].Length;

        //            for (int k = 0; k < menor; k++)
        //            {
        //                pos++;

        //                Trocar(i, j);
        //                //string temp = objeto[i];
        //                //objeto[i] = objeto[j];
        //                //objeto[j] = temp;

        //                break;
        //            }
        //        }
        //    }

        //    //return objeto;
        //    return Lista;
        //}
    }
}
