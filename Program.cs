using System;

namespace Aula18Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            jogador cr7 = new jogador();
            cr7.Nome = "Cristiano Ronaldo";
            cr7.Posicao ="Atacante";
            cr7.Nascimento = DateTime.Parse("05/02/1985");
            
            cr7.MostrarDados();
            Console.WriteLine( cr7.CalcularIdade());
            Console.WriteLine(cr7.CalcularAposentadoria());
        }    
    } 
} 