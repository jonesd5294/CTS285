using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declare user variables
        int int1;
        int int2;
        int answer;
        int var;
                

        private void addButton_Click(object sender, EventArgs e)
        {
            int1 = int.Parse(int1TextBox.Text);
            int2 = int.Parse(int2TextBox.Text);
            answer = int.Parse(answerTextBox.Text);

            var = ClassLibrary.Add.GetAdd(int1, int2);
            
            if(answer == var)
            {
                MessageBox.Show(answer + " is correct!");
            }
            else
            {
                MessageBox.Show(answer + " is incorrect, try again!");
            }


        }

        private void subButton_Click(object sender, EventArgs e)
        {
            int1 = int.Parse(int1TextBox.Text);
            int2 = int.Parse(int2TextBox.Text);
            answer = int.Parse(answerTextBox.Text);

            var = ClassLibrary.Sub.GetSub(int1, int2);

            if (answer == var)
            {
                MessageBox.Show(answer + " is correct!");
            }
            else
            {
                MessageBox.Show(answer + " is incorrect, try again!");
            }
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            int1 = int.Parse(int1TextBox.Text);
            int2 = int.Parse(int2TextBox.Text);
            answer = int.Parse(answerTextBox.Text);

            var = ClassLibrary.Multiply.GetMultiply(int1, int2);

            if (answer == var)
            {
                MessageBox.Show(answer + " is correct!");
            }
            else
            {
                MessageBox.Show(answer + " is incorrect, try again!");
            }
        }

        private void dividButton_Click(object sender, EventArgs e)
        {
            int1 = int.Parse(int1TextBox.Text);
            int2 = int.Parse(int2TextBox.Text);
            answer = int.Parse(answerTextBox.Text);

            var = ClassLibrary.Divide.GetDivide(int1, int2);

            if (answer == var)
            {
                MessageBox.Show(answer + " is correct!");
            }
            else
            {
                MessageBox.Show(answer + " is incorrect, try again!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     }
}
