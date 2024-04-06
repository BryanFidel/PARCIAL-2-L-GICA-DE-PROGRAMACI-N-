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

                while (numberGuessed != randomNumber)
                {
                    for (int i = 1; i <= numPlayers; i++)
                    {
                        Console.Write($"Jugador {i}, ingrese un número: ");
                        int guess = Convert.ToInt32(Console.ReadLine());

                        if (guess < randomNumber)
                        {
                            Console.WriteLine("MAYOR");
                        }
                        else if (guess > randomNumber)
                        {
                            Console.WriteLine("MENOR");
                        }
                        else
                        {
                            Console.WriteLine("¡HAS GANADO!");
                            numberGuessed = guess;
                            break;
                        }
                    }
                }

                
            }

            Console.WriteLine("Gracias por jugar Adivina el Número. ¡Hasta luego!");
        }
    }
}
