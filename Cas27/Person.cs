using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas27
{
    class Person
    {
        private string _firstName = "Petar";
        private string _lastName = "Petrovic";
        private int _age = 30;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string SayAge()
        {
            return $"My age is {Age}";
        }
    }
}
