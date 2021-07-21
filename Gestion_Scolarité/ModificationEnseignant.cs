using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class ModificationEnseignant : Form
    {
        public ModificationEnseignant()
        {
            InitializeComponent();
            Enseignant enseignant = new DAOEnseignantClass().ReadEnseignantById(gestionEnseignants.selectedRowEnseignantId);
            idEnseignantTextBox.Text = enseignant.getId().ToString();
            nomEnseignantTextBox.Text = enseignant.getlastName();
            prenomEnseignantTextBox.Text = enseignant.getfirstName();
            numTelEnseignantTextBox.Text = enseignant.getTelephoneNumber();
            joursEmbaucheEnseignantTextBox.Text = enseignant.getHiringDate().Substring(0, 2);
            moisEmbaucheEnseignantTextBox.Text = enseignant.getHiringDate().Substring(3, 2);
            anneeEmbaucheEnseignantTextBox.Text = enseignant.getHiringDate().Substring(6, 4);
        }

        private void ModifierEnseignantButton_Click(object sender, System.EventArgs e)
        {
            if (new Checker().TelephoneChecker(numTelEnseignantTextBox) && new Checker().DateChecker(joursEmbaucheEnseignantTextBox,moisEmbaucheEnseignantTextBox,anneeEmbaucheEnseignantTextBox))
            {
                new DAOEnseignantClass().UpdateEnseignant(int.Parse(idEnseignantTextBox.Text), new Enseignant(nomEnseignantTextBox.Text, prenomEnseignantTextBox.Text, numTelEnseignantTextBox.Text, joursEmbaucheEnseignantTextBox.Text + '-' + moisEmbaucheEnseignantTextBox.Text + '-' + anneeEmbaucheEnseignantTextBox.Text));
            }
                
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {
            new gestionEnseignants().Show();
            this.Hide();
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

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new ModificationEnseignant().Show();
        }
    }
}
