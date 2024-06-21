namespace GuessingGame
{
    internal class RandomNumber
    {
        Random random = new Random();
        private int _luckyNumber;
        private int _totalAttemps;
        #region Properties
        internal int LuckyNum { get; set; }
        internal int UserGuess { get; set; }
        bool IsWinner { get; set; } = false;
        int TotalAttemps { get; set; }
        #endregion

        #region Constructors
        public RandomNumber()
        {
            LuckyNum = random.Next(1, 100);
        }
        #endregion
        #region Methods
        internal void GuessTheLuckyNum()
        {
            do
            {
                Console.WriteLine(LuckyNum);
                Console.Write("Enter a number: ");
                UserGuess = Convert.ToInt32(Console.ReadLine());
                if (UserGuess == LuckyNum)
                {
                    Console.WriteLine($"Congratulations! You guess the lucky number {LuckyNum}");
                    IsWinner = true;
                    TotalAttemps++;
                    Console.WriteLine($"It took {TotalAttemps} attempt(s) to figure out the lucky number.");
                }
                else if (UserGuess > LuckyNum)
                {
                    Console.WriteLine($"your {UserGuess} is higher than the lucky number. enter a lower number!");
                    TotalAttemps++;
                }
                else if (UserGuess < LuckyNum)
                {
                    Console.WriteLine($"your {UserGuess} is lower than the lucky number. enter a higher number!");
                    TotalAttemps++;
                }
            }
            while (IsWinner == false);
        }
        #endregion
    }
}
