using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class espaceEnseignant : Form
    {
        public espaceEnseignant()
        {
            InitializeComponent();
            classeComboBox = new DAOEmploiClass().FillUpComboBox(classeComboBox);
            classeComboBox.SelectedIndex = 0;
        }

        private void classeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            espaceEnseignantDataGridView.DataSource = new DAOEmploiClass().ReadEmploiByClasse(classeComboBox.SelectedItem.ToString());
        }

        private void logOutButton_Click(object sender, System.EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
