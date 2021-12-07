using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaryConsoleApp
{
     class Employee
    {
        public string firstName;
        public string lastName;
        public string role;

        public Employee(string firstName, string lastName, string role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.role = role;
        }
    }
}
