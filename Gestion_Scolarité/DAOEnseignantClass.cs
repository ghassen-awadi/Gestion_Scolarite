using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_Scolarité
{
    class DAOEnseignantClass
    {
        MySqlConnection sqlConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestionscolarite;");
        public void CreateEnseignant(Enseignant enseignant)
        {
            MySqlCommand cmd = sqlConnection.CreateCommand();

            try
            {
                cmd.CommandText = "insert into teacher(id,lastName,firstName,telephoneNumber,hiringDate) values(" + enseignant.id + ",'" + enseignant.lastName + "','" + enseignant.firstName + "','" + enseignant.telephoneNumber + "','" + enseignant.hiringDate + "')";
                MySqlDataReader MyReader2;
                sqlConnection.Open();
                MyReader2 = cmd.ExecuteReader();
                MessageBox.Show("Data Inserted");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

            sqlConnection.Close();

        }

        public void DeleteEnseignant(int id)
        {
            MySqlCommand cmd = sqlConnection.CreateCommand();

            try
            {
                cmd.CommandText = "DELETE FROM teacher WHERE id = '" + id + "'";
                MySqlDataReader mySqlDataReader;
                sqlConnection.Open();
                mySqlDataReader = cmd.ExecuteReader();
                MessageBox.Show("Data Deleted");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

            sqlConnection.Close();

        }

        public void UpdateEnseignant(int id, Enseignant enseignant)
        {
           
            MySqlCommand cmd = sqlConnection.CreateCommand();

            try
            {
                cmd.CommandText = "UPDATE teacher SET lastName = '" + enseignant.lastName + "', firstName = '" + enseignant.firstName + "', telephoneNumber = '" + enseignant.telephoneNumber + "', hiringDate = '" + enseignant.hiringDate + "' WHERE id ='" + id + "'";

                MySqlDataReader mySqlDataReader;
                sqlConnection.Open();
                mySqlDataReader = cmd.ExecuteReader();
                MessageBox.Show("Data Updated");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

            sqlConnection.Close();

        }

        public DataTable ReadEnseignant()
        {
            DataTable dTable = new DataTable();
            try
            {

                sqlConnection.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT * FROM teacher", sqlConnection);
                sqlConnection.Close();
                MyAdapter.Fill(dTable);
                if (dTable.Rows[dTable.Rows.Count - 1].ItemArray.Length != 0)
                {
                    //dTable.Rows[dTable.Rows.Count - 1].Delete();
                    MessageBox.Show("row deleted");
                }
                
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            return dTable;
        }

        public Enseignant ReadEnseignantById(int id)
        {
            Enseignant enseignant = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM teacher WHERE id=" + id, sqlConnection);
                sqlConnection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    enseignant = new Enseignant(reader.GetInt32("id"), reader.GetString("lastName"), reader.GetString("firstName"), reader.GetString("telephoneNumber"),reader.GetString("hiringDate"));
                }
                sqlConnection.Close();
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }
            return enseignant;
        }

        public string ReadPassword(string id)
        {
            MySqlCommand cmd = sqlConnection.CreateCommand();
            string password = "";
            try
            {
                cmd.CommandText = "SELECT password FROM teacher WHERE id='" + id + "'";
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
