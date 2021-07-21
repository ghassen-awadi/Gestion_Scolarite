using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Scolarité
{
    class Etudiant
    {

        private int id;
        private string lastName, firstName, telephoneNumber, group,password;

        public Etudiant(int id, string lastName, string firstName, string telephoneNumber, string group)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.telephoneNumber = telephoneNumber;
            this.group = group;
        }

        public Etudiant(string lastName, string firstName, string telephoneNumber, string group,string password)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.telephoneNumber = telephoneNumber;
            this.group = group;
            this.password = password;
        }

        public Etudiant(string lastName, string firstName, string telephoneNumber, string group)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.telephoneNumber = telephoneNumber;
            this.group = group;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }


        public string getTelephoneNumber()
        {
            return telephoneNumber;
        }

        public void setTelephoneNumber(string telephoneNumber)
        {
            this.telephoneNumber = telephoneNumber;
        }


        public string getGroup()
        {
            return group;
        }

        public void setGroup(string group)
        {
            this.group = group;
        }
    }
}
