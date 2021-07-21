using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (nomTextBox.TextLength == 0 || prenomTextBox.TextLength == 0 || numTelTextBox.TextLength == 0 || classeTextBox.TextLength == 0 || mdpTextBox.TextLength == 0 || confirmerMdpTextBox.TextLength == 0)
            {
                MessageBox.Show("tous les champs doivent être remplis");
            }
            else if (!mdpTextBox.Text.Equals(confirmerMdpTextBox.Text))
            {
                MessageBox.Show("les mot de passe ne sont pas identiques");
            }
            else if (new Checker().TelephoneChecker(numTelTextBox))
            {
                new DAOEtudiantClass().SignUp(new Etudiant(nomTextBox.Text, prenomTextBox.Text, numTelTextBox.Text, classeTextBox.Text, mdpTextBox.Text));
                this.Hide();
                new espaceEtudiant().Show();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signup().Show();
        }

        private void numTelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }
    }
}
