using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
             string Nome;
             string Sobrenome;
             string tecla;

            do
              {
               Console.Clear();

               Console.WriteLine("       +----------------+");
               Console.WriteLine("       |Manipulando Nome|");
               Console.WriteLine("       +----------------+");

               Console.WriteLine("Qual seu primeiro nome?");
               Nome = Console.ReadLine();
               Console.WriteLine("Qual seu Sobrenome?");
               Sobrenome = Console.ReadLine();

               Console.Clear();
                           Console.ForegroundColor = ConsoleColor.Yellow;
               Console.Write("Nome Completo: ");
                           Console.ResetColor();
               Console.WriteLine($"{Nome} {Sobrenome}");

                            Console.ForegroundColor = ConsoleColor.Yellow;
             Console.Write("Nome Catalogo: ");
                            Console.ResetColor();
               Console.WriteLine($"{Sobrenome.ToUpper()}, {Nome}");
                
                          
               Console.WriteLine("\n Sair? (S)");
               tecla = Console.ReadLine().ToUpper();
              }
            while(tecla != "S");
         Console.Clear();    
        }
    }
}
