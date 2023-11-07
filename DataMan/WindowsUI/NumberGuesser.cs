using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsUI
{
    public partial class NumberGuesser : Form
    {
        public NumberGuesser()
        {
            InitializeComponent();
            guesser = new NumGuess();
            guesser.Initialize(1, 100);
        }

        private NumGuess guesser;


        private void guessButton_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = Convert.ToInt32(guessTextBox.Text);
                string result = guesser.Guess(guess);

                if (!result.Contains("Congratulations"))
                {
                    string hint = guesser.GetHint();
                    MessageBox.Show(result + "\n" + hint, "Guess Result");
                }
                else
                {
                    MessageBox.Show(result, "Congratulations!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input");
            }
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            MainMenu form2 = new MainMenu();
            form2.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            guesser.Initialize(1, 100);
            guessTextBox.Text = "";
            MessageBox.Show("A new random number has been generated.", "New Game");
        }
    }
}
