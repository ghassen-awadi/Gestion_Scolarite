using System;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class espaceAdministrateur : Form
    {
        public espaceAdministrateur()
        {
            InitializeComponent();
        }

        private void suivantButtonEspaceAdminisrateur_Click(object sender, EventArgs e)
        {
            if (gestionEnseignantsRadioButton.Checked)
            {
                new gestionEnseignants().Show();
                this.Hide();
            }
            else if (gestionEtudiantsRadioButton.Checked)
            {
                new gestionEtudiants().Show();
                this.Hide();
            }
            else if (gestionEmploisRadioButton.Checked)
            {
                new gestionEmplois().Show();
                this.Hide();
            }
            else
            {
                new gestionGroupes().Show();
                this.Hide();
            }
        }
    }
}
