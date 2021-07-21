using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class ajoutGroupe : Form
    {
        public ajoutGroupe()
        {
            InitializeComponent();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            new gestionGroupes().Show();
            this.Hide();
        }

        private void AjoutGroupeButton_Click(object sender, EventArgs e)
        {
            new DAOGroupeClass().CreateGroupe(new Groupe(int.Parse(idGroupeTextBox.Text), int.Parse(nbEtudiantsTextBox.Text),nomGroupeTextBox.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ajoutGroupe().Show();
        }
    }

}
