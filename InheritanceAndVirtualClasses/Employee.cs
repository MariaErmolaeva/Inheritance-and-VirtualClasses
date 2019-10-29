using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndVirtualClasses
{
    public class Employee: Person
    {
        private string profession;

        private int workExperience;

        public string getProfession { get { return profession; } }

        public int getWorkExperience { get { return workExperience; } }

        public Employee (string name, int age, string gender, string profession, int workExperience): base (name, age, gender)
        {
            this.profession = profession;
            this.workExperience = workExperience;
        }
    }
}
