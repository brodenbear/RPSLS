using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\nFirst player to 3 points, wins!\nRock crushes Scissors\nScissors cuts Paper \nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n ");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            int playerNumber;

            while (true)
            {
                Console.WriteLine("Will you be playing with 1 or 2 players?");
                string numberOfPlayers = Console.ReadLine();
                if (int.TryParse(numberOfPlayers, out playerNumber) && (playerNumber == 1 || playerNumber == 2))
                {
                    Console.WriteLine($"You have chosen {playerNumber} players");
                    return playerNumber;
                }
                else
                {
                    Console.WriteLine($"You have picked an incorrect number of players, {numberOfPlayers} is not between 1 and 2");
                }
            }
        }
        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
        }
    }
}
