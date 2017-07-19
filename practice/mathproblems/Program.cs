using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerGuess;
            string playerInput;
            bool isNumberGuessed = false;
            int theAnswer;

            Random rng = new Random();
            theAnswer  = rng.Next(1, 21);

            do
            {
                Console.Write("Enter your guess: ");
                playerInput = Console.ReadLine();

                playerGuess = int.Parse(playerInput);

                if (playerGuess == theAnswer)
                {
                    Console.WriteLine("You got it!");
                    isNumberGuessed = true;
                }
                else
                {
                    if (playerGuess > theAnswer)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else
                    {
                        Console.WriteLine("Too low!");
                    }
                }
            } while (!isNumberGuessed);
        }
    }
}
