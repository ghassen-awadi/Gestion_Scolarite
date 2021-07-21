using System;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class gestionEtudiants : Form
    {
        public static int selectedRowEtudiantId;
        public gestionEtudiants()
        {
            InitializeComponent();
            dataGridViewGestionEtudiant.DataSource = new DAOEtudiantClass().ReadEtudiant();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            new espaceAdministrateur().Show();
            this.Hide();
        }

        private void dataGridViewGestionEtudiant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowEtudiantId = int.Parse(dataGridViewGestionEtudiant.CurrentRow.Cells[0].Value.ToString());
        }

        private void ModifierEtudiantPictureBox_Click(object sender, EventArgs e)
        {
            new ModificationEtudiant().Show();
            this.Hide();
        }

        private void AjouterEtudiantPictureBox_Click(object sender, EventArgs e)
        {
            new ajoutEtudiant().Show();
            this.Hide();
        }

        private void SupprimerEtudiantPictureBox_Click(object sender, EventArgs e)
        {
            new DAOEtudiantClass().DeleteEtudiant(selectedRowEtudiantId);
        }
    }
}
