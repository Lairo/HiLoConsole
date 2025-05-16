namespace HiLoConsole
{
    public static class HiLoGame
    {
        private static Random random = new();
        public const int MAXIMUM = 10;
        public static int currentNumber = random.Next(1,MAXIMUM);
        public static int nextNumber = random.Next(1,MAXIMUM);
        private static int pot = MAXIMUM;

        public static void Guess(bool higher)
        {

            if ((higher == true && nextNumber >= currentNumber) ||
                (higher == false && nextNumber <= currentNumber))
            {
                Console.WriteLine("\tYou guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("\tBad luck, you guessed wrong");
                pot--;
            }
            currentNumber = nextNumber;
            nextNumber = random.Next(MAXIMUM);
            Console.WriteLine($"\tThe current number is {currentNumber}");
        }

        public static void Hint()
        {
            double half = (double)nextNumber / 2;
            if (half > currentNumber)
                Console.WriteLine($"The current number is {currentNumber}," +
                    $" the next is at least {half.ToString(".00")}");
            if (half < currentNumber)
                Console.WriteLine($"The current number is {currentNumber}," +
                    $" the next is at most {half.ToString(".00")}");

            pot--;
        }

        public static int GetPot()
        {
            return pot;

        }
    }
}