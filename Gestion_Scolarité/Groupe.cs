using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Scolarité
{
    class Groupe
    {
        private int id, studentNumber;
        private string className;

        public Groupe(int id, int studentNumber, string className)
        {
            this.id = id;
            this.studentNumber = studentNumber;
            this.className = className;
        }

        public Groupe(int studentNumber, string className)
        {
            this.studentNumber = studentNumber;
            this.className = className;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getStudentNumber()
        {
            return studentNumber;
        }

        public void setStudentNumber(int studentNumber)
        {
            this.studentNumber = studentNumber;
        }

        public string getClassName()
        {
            return className;
        }

        public void setClassName(string className)
        {
            this.className = className;
        }
    }
}
