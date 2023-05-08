using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Player
    {
        //Member Variabes (HAS A)
        public string name;
        public List<string> gestures;
        public string chosenGesture;
        public int score;

        //Constructor
        public Player(string name)
        {
            this.name = name;
             gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
            chosenGesture = "";
            score = 0;
        }
        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player classes
        public abstract void ChooseGesture();
    }

    internal class HumanPlayer : Player
    {
        //Constructor
        public HumanPlayer(string name) : base(name)
        {
        }

        public override void ChooseGesture()
        {
            Console.WriteLine($"{name}, please choose a gesture:");
            foreach (var gesture in gestures)
            {
                Console.WriteLine($"- {gesture}");
            }
            chosenGesture = Console.ReadLine().ToLower();
            while (!gestures.Contains(chosenGesture))
            {
                Console.WriteLine("Invalid gesture, please try again.");
                chosenGesture = Console.ReadLine().ToLower();
            }
        }
    }

    internal class ComputerPlayer : Player
    {
        //Constructor
        public ComputerPlayer() : base("Computer")
        {
        }

        public override void ChooseGesture()
        {
            Random random = new Random();
            int index = random.Next(gestures.Count);
            chosenGesture = gestures[index];
        }
    }
}