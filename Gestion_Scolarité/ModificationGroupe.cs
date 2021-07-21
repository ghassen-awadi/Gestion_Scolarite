using System;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class ModificationGroupe : Form
    {
        public ModificationGroupe()
        {
            InitializeComponent();
            Groupe groupe = new DAOGroupeClass().ReadGroupeById(gestionGroupes.selectedRowGroupeId);
            idGroupeTextBox.Text = groupe.getId().ToString();
            nomGroupeTextBox.Text = groupe.getClassName();
            nbEtudiantsTextBox.Text = groupe.getStudentNumber().ToString();
        }

        private void ModifierGroupeButton_Click(object sender, EventArgs e)
        {
            new DAOGroupeClass().UpdateGroupe(int.Parse(idGroupeTextBox.Text), new Groupe(int.Parse(nbEtudiantsTextBox.Text), nomGroupeTextBox.Text));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new gestionGroupes().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ModificationGroupe().Show();
        }
    }
}
