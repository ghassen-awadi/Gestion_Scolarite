using System;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class ajoutEmploi : Form
    {
        public ajoutEmploi()
        {
            InitializeComponent();
        }

        private void RetourPictureBox4_Click(object sender, EventArgs e)
        {
            new gestionEmplois().Show();
            this.Hide();
        }

        private void AjouterEmploiButton_Click(object sender, EventArgs e)
        {
            if (new Checker().DateChecker(jourEmploiTextBox,moisEmploiTextBox,anneeEmploiTextBox))
            {
                new DAOEmploiClass().CreateEmploi(new Emploi(jourEmploiTextBox.Text + '-' + moisEmploiTextBox.Text + '-' + anneeEmploiTextBox.Text, groupeEmploiTextBox.Text, salleEmploiTextBox.Text, matieresRichTextBox.Text));
            }
            
        }

        private void jourEmploiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }

        private void moisEmploiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }

        private void anneeEmploiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ajoutEmploi().Show();
        }
    }
}
