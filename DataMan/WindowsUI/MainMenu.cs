using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void answerCheckerButton_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numGuessButton_Click(object sender, EventArgs e)
        {
            NumberGuesser form3 = new NumberGuesser();
            form3.Show();
            this.Hide();
        }
    }
}
