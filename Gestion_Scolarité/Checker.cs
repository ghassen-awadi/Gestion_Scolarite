
using System.Windows.Forms;

namespace Gestion_Scolarité
{
    class Checker
    {
        public bool TelephoneChecker(TextBox telephoneTextBox)
        {
            if (telephoneTextBox.TextLength != 8)
            {
                MessageBox.Show("le numero de telephone contient seulement 8 chiffres");
                return false;
            }
            return true;
        }

        public bool DateChecker(TextBox dayTextBox,TextBox monthTextBox,TextBox yearTextBox)
        {
            if ((int.Parse(dayTextBox.Text) < 1) || (int.Parse(dayTextBox.Text) > 31))
            {
                MessageBox.Show("le nombre de jours doit être compris entre 1 et 31");
                return false;
            }
            else if ((int.Parse(monthTextBox.Text) < 1) || (int.Parse(monthTextBox.Text) > 12))
            {
                MessageBox.Show("le nombre de mois doit être compris entre 1 et 12");
                return false;
            }
            else if (yearTextBox.TextLength != 4)
            {
                MessageBox.Show("une année contient seulement 4 chiffres");
                return false;
            }
            return true;
        }
    }
}