namespace LevelUp_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            DisplayCommand();
            LevelUpInput();
            DisplayCurrentLevel();
        }

        static int InputUserXP = -1;
        static string input;

        private static void DisplayCommand()
        {
            Console.Write("Input XP: ");
        }

        private static void LevelUpInput()
        {
            input = Console.ReadLine();
            bool success = int.TryParse(input, out InputUserXP);
            if (success)
            {
                LvlUps(InputUserXP);
            }
            else
            {
                Console.WriteLine("Invalid input.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        enum LvlUp
        {
            None = 0,
            Level1 = 20,
            Level2 = 50,
            Level3 = 100,
            Level4 = 250,
            Level5 = 600,
            Level6 = 1400,
            Level7 = 3000,
            Level8 = 6000,
            Level9 = 11000,
        }

        private static LvlUp LvlUps(int InputUserXP)
        {
            if (InputUserXP >= (int)LvlUp.Level9)
            {
                return LvlUp.Level9;
            }
            else if (InputUserXP >= (int)LvlUp.Level8)
            {
                return LvlUp.Level8;
            }
            else if (InputUserXP >= (int)LvlUp.Level7)
            {
                return LvlUp.Level7;
            }
            else if (InputUserXP >= (int)LvlUp.Level6)
            {
                return LvlUp.Level6;
            }
            else if (InputUserXP >= (int)LvlUp.Level5)
            {
                return LvlUp.Level5;
            }
            else if (InputUserXP >= (int)LvlUp.Level4)
            {
                return LvlUp.Level4;
            }
            else if (InputUserXP >= (int)LvlUp.Level3)
            {
                return LvlUp.Level3;
            }
            else if (InputUserXP >= (int)LvlUp.Level2)
            {
                return LvlUp.Level2;
            }
            else if (InputUserXP >= (int)LvlUp.Level1)
            {
                return LvlUp.Level1;
            }
            else
            {
                return LvlUp.None;
            }
        }

        private static void DisplayCurrentLevel()
        {
            Console.WriteLine("Current level: " + LvlUps(InputUserXP));
        }
    }
}