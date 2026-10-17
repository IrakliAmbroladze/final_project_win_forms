using System;
using System.Windows.Forms;
namespace final_project_win_forms
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();
        private int secretNumber; private int attempts;
        public Form1()
        {
            InitializeComponent();
            guessButton.Click += GuessButton_Click;
            newGameButton.Click += NewGameButton_Click;
            StartNewGame();
        }
        private void StartNewGame()
        {
            secretNumber = random.Next(1, 101); attempts = 0;
            guessInput.Minimum = 1; guessInput.Maximum = 100;
            guessInput.Value = 50; guessInput.Enabled = true; guessButton.Enabled = true;
            resultLabel.Text = "Enter a number and click Guess.";
            attemptsLabel.Text = "Attempts: 0";
        }
        private void GuessButton_Click(object sender, EventArgs e)
        {
            int guess = (int)guessInput.Value;
            attempts++;
            attemptsLabel.Text = "Attempts: " + attempts;
            if (guess < secretNumber) resultLabel.Text = "Too low! Try a higher number.";
            else if (guess > secretNumber) resultLabel.Text = "Too high! Try a lower number.";
            else
            {
                resultLabel.Text = "Correct! You guessed it in " + attempts + " attempts."; guessInput.Enabled = false; guessButton.Enabled = false;
            }
        }
        private void NewGameButton_Click(object sender, EventArgs e) { StartNewGame(); }
    }
}
