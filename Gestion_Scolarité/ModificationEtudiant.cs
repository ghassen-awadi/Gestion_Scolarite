using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class ModificationEtudiant : Form
    {
        public ModificationEtudiant()
        {
            InitializeComponent();
            Etudiant etudiant = new DAOEtudiantClass().ReadEtudiantById(gestionEtudiants.selectedRowEtudiantId);
            idEtudiantTextBox.Text = etudiant.getId().ToString();
            nomEtudiantTextBox.Text = etudiant.getLastName();
            prenomEtudiantTextBox.Text = etudiant.getFirstName();
            numTelEtudiantTextBox.Text = etudiant.getTelephoneNumber();
            groupeEtudiantTextBox.Text = etudiant.getGroup();
        }

        private void ModifierEtudiantButton_Click(object sender, System.EventArgs e)
        {
            if (new Checker().TelephoneChecker(numTelEtudiantTextBox))
            {
                new DAOEtudiantClass().UpdateEtudiant(int.Parse(idEtudiantTextBox.Text), new Etudiant(nomEtudiantTextBox.Text, prenomEtudiantTextBox.Text, numTelEtudiantTextBox.Text, groupeEtudiantTextBox.Text));
            }
                
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {
            new gestionEtudiants().Show();
            this.Hide();
        }

        private void numTelEtudiantTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new ModificationEtudiant().Show();
        }
    }
}
