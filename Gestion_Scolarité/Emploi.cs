namespace Gestion_Scolarité
{
    class Emploi
    {
        private string dateTimeTable, groupName, classroom;
        private string subjects;
   

        public Emploi(string dateTimeTable, string groupName, string classroom, string subjects)
        {
            this.dateTimeTable = dateTimeTable;
            this.groupName = groupName;
            this.classroom = classroom;
            this.subjects = subjects;
        }

        public Emploi(string dateTimeTable, string groupName, string classe)
        {
            this.dateTimeTable = dateTimeTable;
            this.groupName = groupName;
            this.classroom = classe;
        }

  

        public string getDateTimeTable()
        {
            return dateTimeTable;
        }

        public void setDateTimeTable(string dateTimeTable)
        {
            this.dateTimeTable = dateTimeTable;
        }

        public string getGroupName()
        {
            return groupName;
        }

        public void setGroupName(string groupName)
        {
            this.groupName = groupName;
        }

        public string getClasse()
        {
            return classroom;
        }

        public void setClasse(string classe)
        {
            this.classroom = classe;
        }

        public string getSubjects()
        {
            return subjects;
        }

        public void setSubjects(string subjects)
        {
            this.subjects = subjects;
        }
    }
}
