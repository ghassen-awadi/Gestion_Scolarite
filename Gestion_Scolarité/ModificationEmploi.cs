using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class ModificationEmploi : Form
    {
        public ModificationEmploi()
        {
            InitializeComponent();
            Emploi emploi = new DAOEmploiClass().ReadEmploiById(gestionEmplois.selectedRowEmploiId);
            groupeEmploiTextBox.Text = emploi.getGroupName();
            salleEmploiTextBox.Text = emploi.getClasse();
            matieresRichTextBox.Text = emploi.getSubjects();
            jourEmploiTextBox.Text = emploi.getDateTimeTable().Substring(0, 2);
            moisEmploiTextBox.Text = emploi.getDateTimeTable().Substring(3, 2);
            anneeEmploiTextBox.Text = emploi.getDateTimeTable().Substring(6, 4);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (new Checker().DateChecker(jourEmploiTextBox, moisEmploiTextBox, anneeEmploiTextBox))
            {
                new DAOEmploiClass().UpdateEmploi(gestionEmplois.selectedRowEmploiId, new Emploi(jourEmploiTextBox.Text + '-' + moisEmploiTextBox.Text + '-' + anneeEmploiTextBox.Text, groupeEmploiTextBox.Text, salleEmploiTextBox.Text, matieresRichTextBox.Text));
            }
                
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {
            new gestionEmplois().Show();
            this.Hide();
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

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new ModificationEmploi().Show();
        }
    }
}
