using System;

class Program
{
    static void Main(string[] args)
    { 
        Random number = new Random();
        int answer = number.Next(1, 101);

        int guess = -1;

        while (guess != answer)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (answer > guess)
            {
               Console.WriteLine("Higher"); 
            }
            else if (answer < guess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
             Console.WriteLine("You guessed it!");   
            }
        }
    }
}