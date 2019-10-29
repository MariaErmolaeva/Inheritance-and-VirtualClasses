using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndVirtualClasses
{
    public class Teacher : Person
    {
        private string position;

        private string department;

        public string getPosition { get { return position; } }
        public string getDepartment { get { return department; } }
        public Teacher (string name, int age, string gender, string position, string department):base (name, age, gender)
        {
            this.position = position;
            this.department = department;
        }
    }
}
