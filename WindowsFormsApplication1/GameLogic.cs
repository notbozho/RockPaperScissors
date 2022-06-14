using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class GameLogic
    {
        public Player player = new Player();
        public Computer computer = new Computer();

        public GameLogic()
        {

        }

        public void setChoices(Choice playerChoice)
        {
            this.player.choice = playerChoice;
            this.computer.choice = getRandomChoice();
        }

        public Choice getRandomChoice()
        {
            Random random = new Random();

            Array allPossibleChoices = Enum.GetValues(typeof(Choice));
            return (Choice)allPossibleChoices.GetValue(random.Next(allPossibleChoices.Length));
        }

        public Choice getMorePowerful(Choice choice)
        {
            switch (choice)
            {
                case Choice.ROCK:
                    return Choice.PAPER;
                case Choice.PAPER:
                    return Choice.SCISSORS;
                default:
                    return Choice.ROCK;
            }
        }

        public BasePlayer getWinner()
        {
            if (getMorePowerful(player.choice) == computer.choice)
            {
                computer.score++;
                return computer;
            }
            else if (getMorePowerful(computer.choice) == player.choice)
            {
                player.score++;
                return player;
            }
            else
            {
                return null;
            }
        }

         
    }
}
