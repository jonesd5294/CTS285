using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NumGuess
    {
        private readonly Random random = new Random();
        private int targetNumber;

        public void Initialize(int minValue, int maxValue)
        {
            targetNumber = random.Next(minValue, maxValue + 1);
        }

        public string Guess(int guess)
        {
            if (guess < targetNumber)
                return "Too low";
            else if (guess > targetNumber)
                return "Too high";
            else
                return "Congratulations! You guessed the number!";
        }

        public string GetHint()
        {
            int lowerHint = Math.Max(1, targetNumber - 4); // Ensure lowerHint is at least 1
            int upperHint = Math.Min(100, targetNumber + 4); // Ensure upperHint is at most 100

            return $"Here's a hint: The number is between {lowerHint} and {upperHint}.";
        }

        public int GetTargetNumber()
        {
            return targetNumber;
        }
    }
}
