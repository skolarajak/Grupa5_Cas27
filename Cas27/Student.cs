using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas27
{
    class Student : Person
    {
        new public string SayAge()
        {
            return $"My age is {Age}, I'm a student.";
        }
    }
}
