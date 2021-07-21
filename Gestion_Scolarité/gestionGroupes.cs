using System;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class gestionGroupes : Form
    {
        public static int selectedRowGroupeId;
        public gestionGroupes()
        {
            InitializeComponent();
            dataGridViewGestionGroupe.DataSource = new DAOGroupeClass().ReadGroupe();
        }


        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            new espaceAdministrateur().Show();
            this.Hide();
        }



        private void dataGridViewGestionGroupe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowGroupeId = int.Parse(dataGridViewGestionGroupe.CurrentRow.Cells[0].Value.ToString());
        }

        private void ModifierGroupePictureBox_Click(object sender, EventArgs e)
        {
            new ModificationGroupe().Show();
            this.Hide();
        }

        private void AjouterGroupePictureBox_Click(object sender, EventArgs e)
        {
            new ajoutGroupe().Show();
            this.Hide();
        }

        private void SupprimerGroupePictureBox_Click(object sender, EventArgs e)
        {
            new DAOGroupeClass().DeleteGroupe(selectedRowGroupeId);
        }
    }
}
