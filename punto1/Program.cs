using System;

namespace punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playAgain = 1;

            while (playAgain == 1)
            {
                int numPlayers = 0;
                int maxRange = 0;

                while (numPlayers < 2 || numPlayers > 4)
                {
                    Console.Write("Ingrese el número de jugadores (entre 2 y 4): ");
                    numPlayers = Convert.ToInt32(Console.ReadLine());
                }

                maxRange = numPlayers * 50;

                int randomNumber = random.Next(0, maxRange + 1);
                int numberGuessed = -1;

                Console.WriteLine($"Se ha escogido un número entre 0 y {maxRange}. Comencemos a adivinar!");

                
            }

            Console.WriteLine("Gracias por jugar Adivina el Número. ¡Hasta luego!");
        }
    }
}
