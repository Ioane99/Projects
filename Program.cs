using System;

namespace MyfirstProgram
{
    class Program
    {
        static void Main(String[] args)
        { // I.P
            Random random = new Random();
            bool playagain = true;
            int min = 1;
            int max = 100;
            int guess;
            int guesses;
            int number;
            String response;

            while (playagain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next( min, max + 1);
                  while(guess != number)
                {
                    Console.WriteLine("Guess the number between " + min + " - " + max );
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess:" + guess);
                     if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high");
                    }
                    if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low");
                    }
                    guesses++;
                }
                Console.WriteLine("You Guessed Right Number!");
                Console.WriteLine("Would you like to play again? (Y/N) Y = yes, N = No");
                response = Console.ReadLine();
                response = response.ToUpper();
                 if (response == "Y")
                {
                    playagain = true;

                }
                else 
                {
                    playagain = false;

                }


            }
          

            
        }
    }
}
