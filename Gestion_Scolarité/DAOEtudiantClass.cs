using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_Scolarité
{
    class DAOEtudiantClass
    {
        MySqlConnection sqlConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestionscolarite;");
        public DAOEtudiantClass() { }

        public void CreateEtudiant(Etudiant etudiant)
        {

            MySqlCommand cmd = sqlConnection.CreateCommand();

            try
            {
                cmd.CommandText = "insert into student values(" + etudiant.getId() + ",'" + etudiant.getLastName() + "','" + etudiant.getFirstName() + "','" + etudiant.getTelephoneNumber() + "','" + etudiant.getGroup() + "')";
                MySqlDataReader MyReader;
                sqlConnection.Open();
                MyReader = cmd.ExecuteReader();
                MessageBox.Show("Data Inserted");
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }

            sqlConnection.Close();
        }

        public void SignUp(Etudiant etudiant)
        {

            MySqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = "insert into student (lastName,firstName,telephoneNumber,class,password) values('" + etudiant.getLastName() + "','" + etudiant.getFirstName() + "','" + etudiant.getTelephoneNumber() + "','" + etudiant.getGroup() + "','"+etudiant.getPassword()+"')";
                MySqlDataReader MyReader;
                sqlConnection.Open();
                MyReader = cmd.ExecuteReader();
                MessageBox.Show("Data Inserted");
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }

            sqlConnection.Close();
        }

        public void DeleteEtudiant(int id)
        {

            MySqlCommand cmd = sqlConnection.CreateCommand();

            try
            {
                cmd.CommandText = "DELETE FROM student WHERE id = '" + id + "'";
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

        public void UpdateEtudiant(int id, Etudiant etudiant)
        {


            try
            {
                sqlConnection.Open();
                new MySqlCommand("UPDATE student SET lastName = '" + etudiant.getLastName() + "', firstName = '" + etudiant.getFirstName() + "', telephoneNumber = '" + etudiant.getTelephoneNumber() + "', class = '" + etudiant.getGroup() + "' WHERE id =" + id, sqlConnection).ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                sqlConnection.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

        }


        public DataTable ReadEtudiant()
        {
            DataTable dTable = new DataTable();
            try
            {

                sqlConnection.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT * FROM student", sqlConnection);
                sqlConnection.Close();
                MyAdapter.Fill(dTable);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }


            return dTable;
        }

        public Etudiant ReadEtudiantById(int id)
        {
            Etudiant etudiant = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM student WHERE id=" + id, sqlConnection);
                sqlConnection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    etudiant = new Etudiant(reader.GetInt32("id"),reader.GetString("lastName"),reader.GetString("firstName"),reader.GetString("telephoneNumber"), reader.GetString("class"));
                }
                sqlConnection.Close();
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }
            return etudiant;
        }

        public string ReadPassword(string id)
        {
            MySqlCommand cmd = sqlConnection.CreateCommand();
            string password = "";
            try
            {
                cmd.CommandText = "SELECT password FROM student WHERE id='" + id + "'";
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
