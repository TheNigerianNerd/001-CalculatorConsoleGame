using System.Diagnostics;

internal class GameEngine
{
    internal void DivisionGame(GameDifficulty difficulty)
    {
        var random = new Random();
        int firstNumber;
        int secondNumber;
        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();

             //Set difficulty based on  input parameter 'difficulty'
            switch (difficulty)
            {
                case GameDifficulty.Easy:
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);
                    break;
                case GameDifficulty.Medium:
                    firstNumber = random.Next(1, 99);
                    secondNumber = random.Next(1, 99);
                    break;
                case GameDifficulty.Hard:
                    firstNumber = random.Next(1, 999);
                    secondNumber = random.Next(1, 999);
                    break;
            }        

            int[] divisionNumbers = Helpers.GetDivisionNumbers();
            firstNumber = divisionNumbers[0];
            secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");

            var result = Console.ReadLine();

            while (string.IsNullOrEmpty(result) || !int.TryParse(result, out _))
            {
                Console.WriteLine("Your input needs to be an integer. Try again.");
                result = Console.ReadLine();
            }

            if (int.Parse(result) == firstNumber / secondNumber)
            {
                score += 10;
                Console.WriteLine("Your answer was correct.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }
            if (i == 4)
            {
                Console.WriteLine($"Game over. Your final score is {score}/50. \nPress any key to go back to the main menu.");
                Console.ReadLine();
            }
        }
        Helpers.AddToHistory(score, GameType.Division);
    }

    internal void MultiplicationGame(GameDifficulty difficulty)
    {
        var random = new Random();
        int firstNumber = 0;
        int secondNumber = 0;

        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();

             //Set difficulty based on  input parameter 'difficulty'
            switch (difficulty)
            {
                case GameDifficulty.Easy:
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);
                    break;
                case GameDifficulty.Medium:
                    firstNumber = random.Next(1, 99);
                    secondNumber = random.Next(1, 99);
                    break;
                case GameDifficulty.Hard:
                    firstNumber = random.Next(1, 999);
                    secondNumber = random.Next(1, 999);
                    break;
            }        

            Console.WriteLine($"{firstNumber} * {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            //todo-refactor subtraction to limit the occurence of negative results
            if (int.Parse(result) == firstNumber * secondNumber)
            {
                score += 10;
                Console.WriteLine("Your answer was correct.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over. Your final score is {score}/50 Press any key to go back to the main menu.");
                Console.ReadLine();
            }
        }
        Helpers.AddToHistory(score, GameType.Multiplication);
    }

    internal void SubtractionGame(GameDifficulty difficulty)
    {
        var random = new Random();
        int firstNumber = 0;
        int secondNumber = 0;
        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();

             //Set difficulty based on  input parameter 'difficulty'
            switch (difficulty)
            {
                case GameDifficulty.Easy:
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);
                    break;
                case GameDifficulty.Medium:
                    firstNumber = random.Next(1, 99);
                    secondNumber = random.Next(1, 99);
                    break;
                case GameDifficulty.Hard:
                    firstNumber = random.Next(1, 999);
                    secondNumber = random.Next(1, 999);
                    break;
            }        

            Console.WriteLine($"{firstNumber} - {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            //todo-refactor subtraction to limit the occurence of negative results
            if (int.Parse(result) == firstNumber - secondNumber)
            {
                score += 10;
                Console.WriteLine("Your answer was correct.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over. Your final score is {score}/50 Press any key to go back to the main menu.");
                Console.ReadLine();
            }
        }
        Helpers.AddToHistory(score, GameType.Subtraction);
    }

    internal void AdditionGame(GameDifficulty difficulty)
    {
        var random = new Random();
        int firstNumber = 0;
        int secondNumber = 0;
        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();

            //Set difficulty based on  input parameter 'difficulty'
            switch (difficulty)
            {
                case GameDifficulty.Easy:
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);
                    break;
                case GameDifficulty.Medium:
                    firstNumber = random.Next(1, 99);
                    secondNumber = random.Next(1, 99);
                    break;
                case GameDifficulty.Hard:
                    firstNumber = random.Next(1, 999);
                    secondNumber = random.Next(1, 999);
                    break;
            }          

            Console.WriteLine($"{firstNumber} + {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber + secondNumber)
            {
                score += 10;
                Console.WriteLine("Your answer was correct.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over. Your final score is {score}/50 Press any key to go back to the main menu.");
                Console.ReadLine();
            }
        }
        Helpers.AddToHistory(score, GameType.Addition);
    }
}