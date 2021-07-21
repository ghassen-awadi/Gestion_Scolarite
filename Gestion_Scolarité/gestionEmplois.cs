using System;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class gestionEmplois : Form
    {
        public static int selectedRowEmploiId;
        public gestionEmplois()
        {
            InitializeComponent();
            dataGridViewGestionEmploi.DataSource = new DAOEmploiClass().ReadEmploi();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            new espaceAdministrateur().Show();
            this.Hide();
        }

        private void dataGridViewGestionEmploi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowEmploiId = int.Parse(dataGridViewGestionEmploi.CurrentRow.Cells[0].Value.ToString());
        }

        private void ModifierEmploiPictureBox_Click(object sender, EventArgs e)
        {
            new ModificationEmploi().Show();
            this.Hide();
        }

        private void SupprimerEmploiPictureBox_Click(object sender, EventArgs e)
        {
            new DAOEmploiClass().DeleteEmploi(selectedRowEmploiId);
        }

        private void AjouterEmploiPictureBox_Click(object sender, EventArgs e)
        {
            new ajoutEmploi().Show();
            this.Hide();
        }
    }
}
