using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_Scolarité
{
    class DAOGroupeClass
    {
        MySqlConnection sqlConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestionscolarite;");

        public void CreateGroupe(Groupe groupe)
        {

            MySqlCommand cmd = sqlConnection.CreateCommand();

            try
            {
                cmd.CommandText = "insert into class values(" + groupe.getId() + "," + groupe.getStudentNumber() + ",'" + groupe.getClassName() + "')";
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

        public void DeleteGroupe(int id)
        {

            MySqlCommand cmd = sqlConnection.CreateCommand();

            try
            {
                cmd.CommandText = "DELETE FROM class WHERE id = '" + id + "'";
                MySqlDataReader mySqlDataReader;
                sqlConnection.Open();
                mySqlDataReader = cmd.ExecuteReader();
                MessageBox.Show("Data Deleted");
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }

            sqlConnection.Close();

        }

        public void UpdateGroupe(int id, Groupe groupe)
        {


            try
            {
                sqlConnection.Open();
                new MySqlCommand("UPDATE class SET studentNumber = " + groupe.getStudentNumber() + ", className = '" + groupe.getClassName() + "' WHERE id =" + id, sqlConnection).ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                sqlConnection.Close();
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }

        }

        public DataTable ReadGroupe()
        {
            DataTable dTable = new DataTable();
            try
            {

                sqlConnection.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT * FROM class", sqlConnection);
                sqlConnection.Close();
                MyAdapter.Fill(dTable);
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }


            return dTable;
        }

        public Groupe ReadGroupeById(int id)
        {
            Groupe groupe = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM class WHERE id="+id,sqlConnection);
                sqlConnection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    groupe = new Groupe(reader.GetInt32("id"),reader.GetInt32("studentNumber"),reader.GetString("className"));
                }
                    //  MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT * FROM class WHERE id="+id, sqlConnection);
                    sqlConnection.Close();
                //MyAdapter.Fill(dTable);
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }


            return groupe ;
        }
    }
}
