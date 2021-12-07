using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaryConsoleApp
{
     class Doctor:Employee,IComparable
    {
        public int patients;
        public string dateOfBirth;

        public Doctor(string firstName, string lastName, string role,int patients, string dateOfBirth) : base(firstName, lastName, role)
        {
            this.patients = patients;
            this.dateOfBirth = dateOfBirth;
        }

        public int CompareTo(object? obj)
        {
            Doctor other = (Doctor)obj;
            if (this.patients > other.patients) return 1;
            else if(this.patients < other.patients) return -1;
            else return 0;
        }
    }
}
