using System;
public enum InputRobot { ROCK, PAPER, SCISSORS }
namespace ROCKPAPERSCISSORS
{

    class StartUp
    {

        static void Main(string[] args)
        {
            string inputPlayer;


            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreRobot = 0;

                while (scorePlayer < 3 && scoreRobot < 3)
                {


                    Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();


                    InputRobot robot = (InputRobot)(new Random()).Next(1, 3);


                    if (inputPlayer == "ROCK" || inputPlayer == "PAPER" || inputPlayer == "SCISSORS")
                    {
                        switch (robot)
                        {
                            case InputRobot.ROCK:
                                Rock(inputPlayer, ref scorePlayer, ref scoreRobot);
                                break;
                            case InputRobot.PAPER:
                                Paper(inputPlayer, ref scorePlayer, ref scoreRobot);
                                break;
                            case InputRobot.SCISSORS:
                                Scissors(inputPlayer, ref scorePlayer, ref scoreRobot);
                                break;
                            default:

                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry! \nYou can choose - ROCK , PAPER or SCISSORS");
                        continue;
                    }
                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tROBOT:\t{1}", scorePlayer, scoreRobot);

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (scoreRobot == 3)
                {
                    Console.WriteLine("ROBOT WON!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    FinishText();
                }
                else
                {
                    while (playAgain)
                    {
                        Console.WriteLine("Do you want to play again?(y/n)");
                        loop = Console.ReadLine().ToLower();
                        if (loop == "y")
                        {
                            playAgain = true;
                            Console.Clear();
                            break;
                        }
                        else if (loop == "n")
                        {
                            playAgain = FinishText();

                        }
                    }

                }
            }
        }

        private static void Scissors(string inputPlayer, ref int scorePlayer, ref int scoreRobot)
        {
            Console.WriteLine("ROBOT chose SCISSORS");
            if (inputPlayer == "SCISSORS")
            {
                Console.WriteLine("DRAW!!\n");
            }
            else if (inputPlayer == "ROCK")
            {
                Console.WriteLine("PLAYER WINS!!\n");
                scorePlayer++;
            }
            else if (inputPlayer == "PAPER")
            {
                Console.WriteLine("ROBOT WINS!!\n");
                scoreRobot++;
            }
        }

        private static void Paper(string inputPlayer, ref int scorePlayer, ref int scoreRobot)
        {
            Console.WriteLine("ROBOT chose PAPER");
            if (inputPlayer == "PAPER")
            {
                Console.WriteLine("DRAW!!\n");
            }
            else if (inputPlayer == "ROCK")
            {
                Console.WriteLine("ROBOT WINS!!\n");
                scoreRobot++;
            }
            else if (inputPlayer == "SCISSORS")
            {
                Console.WriteLine("PLAYER WINS!!\n");
                scorePlayer++;
            }
        }

        private static void Rock(string inputPlayer, ref int scorePlayer, ref int scoreRobot)
        {
            Console.WriteLine("ROBOT chose ROCK");
            if (inputPlayer == "ROCK")
            {
                Console.WriteLine("DRAW!!\n");
            }
            else if (inputPlayer == "PAPER")
            {
                Console.WriteLine("PLAYER WINS!!\n");
                scorePlayer++;
            }
            else if (inputPlayer == "SCISSORS")
            {
                Console.WriteLine("ROBOT WINS!!\n");
                scoreRobot++;
            }
        }

        private static bool FinishText()
        {
            bool playAgain;
            string readGoodBye = "GOOD BYE !";

            playAgain = false;
            Console.SetCursorPosition((Console.WindowWidth - readGoodBye.Length) / 2, Console.CursorTop);

            Console.WriteLine(readGoodBye);
            Console.SetCursorPosition((Console.WindowWidth - readGoodBye.Length) / 2, Console.CursorTop);


            Console.WriteLine(readGoodBye);
            Console.SetCursorPosition((Console.WindowWidth - readGoodBye.Length) / 2, Console.CursorTop);
            Console.WriteLine(readGoodBye);
            return playAgain;
        }

    }
}

