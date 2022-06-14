using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public GameLogic gameLogic;

        public Form1()
        {
            InitializeComponent();
            this.gameLogic = new GameLogic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logoBox.ImageLocation = ".//logo.png";
            computerIcon.ImageLocation = ".//cpu.png";
            userIcon.ImageLocation = ".//user.png";
        }

        private void rockBtn_Click(object sender, EventArgs e)
        {
            this.gameLogic.setChoices(Choice.ROCK);
            finalizeRound(this.gameLogic.getWinner());
        }

        private void paperBtn_Click(object sender, EventArgs e)
        {
            this.gameLogic.setChoices(Choice.PAPER);
            finalizeRound(this.gameLogic.getWinner());
        }

        private void scissorsBtn_Click(object sender, EventArgs e)
        {
            this.gameLogic.setChoices(Choice.SCISSORS);
            finalizeRound(this.gameLogic.getWinner());
        }

        //new game
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            this.gameLogic = new GameLogic();
            playerScoreLabel.Text = "0";
            computerScoreLabel.Text = "0";

            rockBtn.Show();
            paperBtn.Show();
            scissorsBtn.Show();

            finalWinnerLabel.Text = "";

            playerScoreLabel.ForeColor = Color.Black;
            computerScoreLabel.ForeColor = Color.Black;

            computerChoiceIcon.ImageLocation = "";
            userChoiceIcon.ImageLocation = "";
            playerStateLabel.Text = "";
            computerStateLabel.Text = "";
            
        }

        private String getIconPath(Choice choice)
        {
            switch(choice) {
                case Choice.ROCK:
                    return ".\\rock.png";
                case Choice.PAPER:
                    return ".\\paper.png";
                default:
                    return ".\\scissors.png";
            }
        }

        //updates winner/loser labels
        private void setStates(BasePlayer winner)
        {
            if(winner == gameLogic.player) {
                computerStateLabel.ForeColor = Color.Red;
                computerStateLabel.Text = "Loser";

                playerStateLabel.ForeColor = Color.Green;
                playerStateLabel.Text = "Winner";
            }
            else if (winner == gameLogic.computer)
            {
                computerStateLabel.ForeColor = Color.Green;
                computerStateLabel.Text = "Winner";

                playerStateLabel.ForeColor = Color.Red;
                playerStateLabel.Text = "Loser";
            }
            else
            {
                computerStateLabel.ForeColor = Color.Black;
                computerStateLabel.Text = "Draw";

                playerStateLabel.ForeColor = Color.Black;
                playerStateLabel.Text = "Draw";
            }
        }

        //updates values after each round
        private void finalizeRound(BasePlayer winner)
        {
            
            computerChoiceIcon.ImageLocation = getIconPath(this.gameLogic.computer.choice);
            userChoiceIcon.ImageLocation = getIconPath(this.gameLogic.player.choice);
            setStates(winner);
            playerScoreLabel.Text = "" + this.gameLogic.player.score;
            computerScoreLabel.Text = "" + this.gameLogic.computer.score;
            
            //Change the winning score color to yellow
            if (this.gameLogic.player.score > this.gameLogic.computer.score)
            {
                playerScoreLabel.ForeColor = Color.DarkGoldenrod;
                computerScoreLabel.ForeColor = Color.Black;
            }
            else if (this.gameLogic.computer.score > this.gameLogic.player.score)
            {
                playerScoreLabel.ForeColor = Color.Black;
                computerScoreLabel.ForeColor = Color.DarkGoldenrod;
            }
            else
            {
                playerScoreLabel.ForeColor = Color.Black;
                computerScoreLabel.ForeColor = Color.Black;
            }

            //checks for final winner
            if (this.gameLogic.player.score == 10 && this.gameLogic.computer.score < 10)
            {
                rockBtn.Hide();
                paperBtn.Hide();
                scissorsBtn.Hide();
                finalWinnerLabel.Text = "Player Wins!";
                finalWinnerLabel.ForeColor = Color.Green;
            }
            else if (this.gameLogic.computer.score == 10 && this.gameLogic.player.score < 10)
            {
                rockBtn.Hide();
                paperBtn.Hide();
                scissorsBtn.Hide();
                finalWinnerLabel.Text = "Computer Wins!";
                finalWinnerLabel.ForeColor = Color.Green;
            }
        }

        
    }
}
