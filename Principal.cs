using System;

namespace BancoDeSeries
{
    partial class Program
    {
        static bool sair = false;

        static void Main()
        {
            try
            {
                while (!sair)
                {
                    TelaPrincipal();
                }

                Console.WriteLine("VOLTE SEMPRE! :D");
                Console.ReadKey();
            }
           
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine("Isso certamente é culpa do usuário.");
                while (true)
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
