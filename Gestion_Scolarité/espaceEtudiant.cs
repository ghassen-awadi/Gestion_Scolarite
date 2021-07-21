using System;
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    public partial class espaceEtudiant : Form
    {
        public espaceEtudiant()
        {
            InitializeComponent();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (classeTextBox.TextLength == 0)
            {
                MessageBox.Show("le champs classe doit être rempli");
                this.ActiveControl = classeTextBox;
            }
            else if (jourTextBox.Text.Equals("JOUR") || moisTextBox.Text.Equals("MOIS") || anneeTextBox.Text.Equals("ANNEE"))
            {
                MessageBox.Show("le champs date doit être rempli");
                this.ActiveControl = jourTextBox;
            }
            else if (new Checker().DateChecker(jourTextBox,moisTextBox,anneeTextBox))
            {
                espaceEtudiantDataGridView.DataSource = new DAOEmploiClass().ReadEmploiByClasseAndDate(classeTextBox.Text, jourTextBox.Text + '-' + moisTextBox.Text + '-' + anneeTextBox.Text);
            }
            
        }

        private void jourTextBox_Enter(object sender, EventArgs e)
        {
            if (jourTextBox.Text.Equals("JOUR"))
            jourTextBox.Text = "";
            jourTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void jourTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(jourTextBox.Text))
            {
                jourTextBox.Text = "JOUR";
                jourTextBox.ForeColor = System.Drawing.Color.Silver;
            }
            
        }

        private void moisTextBox_Enter(object sender, EventArgs e)
        {
            if (moisTextBox.Text.Equals("MOIS"))
            moisTextBox.Text = "";
            moisTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void moisTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(moisTextBox.Text))
            {
                moisTextBox.Text = "MOIS";
                moisTextBox.ForeColor = System.Drawing.Color.Silver;
            }
            
        }

        private void anneeTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(anneeTextBox.Text))
            {
                anneeTextBox.Text = "ANNEE";
                anneeTextBox.ForeColor = System.Drawing.Color.Silver;
            }
               
        }

        private void anneeTextBox_Enter(object sender, EventArgs e)
        {
            if (anneeTextBox.Text.Equals("ANNEE"))
            anneeTextBox.Text = "";
            anneeTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void jourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }

        private void moisTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }

        private void anneeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Ce champ n'accepte que des chiffres");
            }
        }
    }
}
