using System;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class Login : Form
    {
        string userPassword;
        public Login()
        {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar = true;
            espaceComboBox.SelectedIndex = 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            switch (espaceComboBox.SelectedIndex) 
            {
                case 1:
                    userPassword = new DAOAdminClass().ReadPassword(IDTextBox.Text);
                    if (userPassword.Equals(passwordTextBox.Text))
                    {
                        {
                            new espaceAdministrateur().Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id ou Mot De Passe invalide");
                    }
                    break;
                case 2:
                    userPassword = new DAOEtudiantClass().ReadPassword(IDTextBox.Text);
                    if (userPassword.Equals(passwordTextBox.Text))
                    {
                        {
                            new espaceEtudiant().Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id ou Mot De Passe invalide");
                    }
                    break;
                case 3:
                    userPassword = new DAOEnseignantClass().ReadPassword(IDTextBox.Text);
                    if (userPassword.Equals(passwordTextBox.Text))
                    {
                        {
                            new espaceEnseignant().Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id ou Mot De Passe invalide");
                    }
                    break;
                default:
                    MessageBox.Show("Vous devez choisir un espace");
                    break;
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = "";
            passwordTextBox.Text = "";
            espaceComboBox.SelectedIndex = 0;
            showPasswordCheckBox.Checked = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Signup().Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
