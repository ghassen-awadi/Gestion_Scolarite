using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_Scolarité
{
    class DAOAdminClass
    {
		public string ReadPassword(string id)
		{
			MySqlConnection sqlConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestionscolarite;");
			MySqlCommand cmd = sqlConnection.CreateCommand();
			string password = "";
			try
			{
				cmd.CommandText = "SELECT password FROM admin WHERE id='" + id + "'";
				sqlConnection.Open();
			}
			catch (MySqlException m)
			{
                MessageBox.Show(m.Message);
            }

			MySqlDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				password = reader.GetString(0);
			}
			return password;
		}
	}
}
