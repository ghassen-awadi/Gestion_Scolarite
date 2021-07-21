using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_Scolarité
{
    class DAOEmploiClass
    {
        MySqlConnection sqlConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestionscolarite;");

        public void CreateEmploi(Emploi emploi)
        {

            MySqlCommand cmd = sqlConnection.CreateCommand();

            try
            {
                cmd.CommandText = "insert into timetable (dateTimeTable,groupName,classroom,subjects) values('" + emploi.getDateTimeTable() + "','" + emploi.getGroupName() + "','" + emploi.getClasse() + "','" + emploi.getSubjects() + "')";
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

        public void DeleteEmploi(int id)
        {

            MySqlCommand cmd = sqlConnection.CreateCommand();

            try
            {
                cmd.CommandText = "DELETE FROM timetable WHERE id = '" + id + "'";
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

        public void UpdateEmploi(int id, Emploi emploi)
        {
            try
            {
                sqlConnection.Open();
                new MySqlCommand("UPDATE timetable SET dateTimeTable = '" + emploi.getDateTimeTable() + "', groupName = '" + emploi.getGroupName() + "', classroom = '" + emploi.getClasse() + "', subjects = '" + emploi.getSubjects() + "' WHERE id =" + id, sqlConnection).ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                sqlConnection.Close();
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }

        }


        public DataTable ReadEmploi()
        {
            DataTable dTable = new DataTable();
            try
            {

                sqlConnection.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT * FROM timetable", sqlConnection);
                sqlConnection.Close();
                MyAdapter.Fill(dTable);
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }


            return dTable;
        }

        public Emploi ReadEmploiById(int id)
        {
         
                Emploi emploi = null;
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM timetable WHERE id=" + id, sqlConnection);
                    sqlConnection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        emploi = new Emploi(reader.GetString("dateTimeTable"), reader.GetString("groupName"), reader.GetString("classroom"),reader.GetString("subjects"));
                    }
                    sqlConnection.Close();
                }
                catch (MySqlException m)
                {
                    MessageBox.Show(m.Message);
                }
                return emploi;
            
        }

        public ComboBox FillUpComboBox(ComboBox comboBox)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT groupName FROM timetable", sqlConnection);
                sqlConnection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader.GetString("groupName"));
                }
                sqlConnection.Close();
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }
            return comboBox;
        }

        public DataTable ReadEmploiByClasse(string classe)
        {
            DataTable dTable = new DataTable();
            try
            {
                sqlConnection.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT dateTimeTable,groupName,classroom,subjects FROM timetable WHERE groupName='" + classe + "'", sqlConnection);
                sqlConnection.Close();
                MyAdapter.Fill(dTable);
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }
            return dTable;

        }

        public DataTable ReadEmploiByClasseAndDate(string classe,string date)
        {
            DataTable dTable = new DataTable();
            try
            {
                sqlConnection.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT dateTimeTable,groupName,classroom,subjects FROM timetable WHERE groupName = '" + classe + "'" +"AND datetimetable = '" + date + "'", sqlConnection);
                sqlConnection.Close();
                MyAdapter.Fill(dTable);
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }
            return dTable;

        }
    }
}
