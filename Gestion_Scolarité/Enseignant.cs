using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Scolarité
{
    class Enseignant
    {
        public int id;
        public string lastName;
        public string firstName;
        public string telephoneNumber;
        public string hiringDate;

        public Enseignant(int id, string lastName, string firstName, string telephoneNumber, string hiringDate)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.telephoneNumber = telephoneNumber;
            this.hiringDate = hiringDate;
        }

        public Enseignant(string lastName, string firstName, string telephoneNumber, string hiringDate)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.telephoneNumber = telephoneNumber;
            this.hiringDate = hiringDate;
        }

        public int getId()
        {
            return id;
        }

        public string getlastName()
        {
            return lastName;
        }

        public string getfirstName()
        {
            return firstName;
        }

        public string getTelephoneNumber()
        {
            return telephoneNumber;
        }

        public string getHiringDate()
        {
            return hiringDate;
        }
    }
}
