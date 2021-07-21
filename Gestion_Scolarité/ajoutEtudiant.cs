using System;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class ajoutEtudiant : Form
    {
        public ajoutEtudiant()
        {
            InitializeComponent();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            new gestionEtudiants().Show();
            this.Hide();
        }

        private void AjouterEtudiantButton_Click(object sender, EventArgs e)
        {
            if (new Checker().TelephoneChecker(numTelEtudiantTextBox))
            {
                new DAOEtudiantClass().CreateEtudiant(new Etudiant(nomEtudiantTextBox.Text, prenomEtudiantTextBox.Text, numTelEtudiantTextBox.Text, groupeEtudiantTextBox.Text));
            }
                
        }

        private void numTelEtudiantTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ajoutEtudiant().Show();
        }
    }
}
