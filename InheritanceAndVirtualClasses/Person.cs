using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndVirtualClasses
{
    public class Person
    {
        protected string name;
        protected int age;
        protected string gender;


        public string getName { get { return name; } }
        public int getAge { get { return age; } }
        public string getGender { get { return gender; } }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }
}
