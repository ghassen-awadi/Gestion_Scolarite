using System;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class ajoutEnseignant : Form
    {
        public ajoutEnseignant()
        {
            InitializeComponent();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            new gestionEnseignants().Show();
            this.Hide();
        }

        private void AjouterEnseignantButton_Click(object sender, EventArgs e)
        {
            if (new Checker().TelephoneChecker(numTelEnseignantTextBox) && new Checker().DateChecker(joursEmbaucheEnseignantTextBox, moisEmbaucheEnseignantTextBox, anneeEmbaucheEnseignantTextBox))
            {
                new DAOEnseignantClass().CreateEnseignant(new Enseignant(int.Parse(idEnseignantTextBox.Text), nomEnseignantTextBox.Text, prenomEnseignantTextBox.Text, numTelEnseignantTextBox.Text, joursEmbaucheEnseignantTextBox.Text + '-' + moisEmbaucheEnseignantTextBox.Text + '-' + anneeEmbaucheEnseignantTextBox.Text));
            }
            
        }

        private void numTelEnseignantTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }

        private void joursEmbaucheEnseignantTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }

        private void moisEmbaucheEnseignantTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }

        private void anneeEmbaucheEnseignantTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ajoutEnseignant().Show();
        }
    }
}
