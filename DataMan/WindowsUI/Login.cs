using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ncmik\Desktop\DataMan\WindowsUI\Login.mdf;Integrated Security=True");

        private void loginButton_Click(object sender, EventArgs e)
        {
            String userName, userPassword;

            userName = nameTextBox.Text;
            userPassword = passTextBox.Text;

            try
            {
                String querry = "SELECT * FROM Login WHERE username = '" + nameTextBox.Text + "' AND password = '" + passTextBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if(dTable.Rows.Count > 0 )
                {
                    userName = nameTextBox.Text; 
                    userPassword = passTextBox.Text;

                    MainMenu form2 = new MainMenu();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login attempt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTextBox.Clear();
                    passTextBox.Clear();    

                    nameTextBox.Focus();    
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            passTextBox.Clear();

            nameTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
