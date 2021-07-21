using System;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class gestionEnseignants : Form
    {
        public static int selectedRowEnseignantId;
        public gestionEnseignants()
        {
            InitializeComponent();
            dataGridViewGestionEnseignant.DataSource = new DAOEnseignantClass().ReadEnseignant();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            new espaceAdministrateur().Show();
            this.Hide();
        }

        private void dataGridViewGestionEnseignant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowEnseignantId = int.Parse(dataGridViewGestionEnseignant.CurrentRow.Cells[0].Value.ToString());
        }

        private void ModifierEnseignantPictureBox_Click(object sender, EventArgs e)
        {
            new ModificationEnseignant().Show();
            this.Hide();
        }

        private void AjouterEnseignantPictureBox_Click(object sender, EventArgs e)
        {
            new ajoutEnseignant().Show();
            this.Hide();
        }

        private void SupprimerEnseignantPictureBox_Click(object sender, EventArgs e)
        {
            new DAOEnseignantClass().DeleteEnseignant(selectedRowEnseignantId);
        }

      
    }
}
