using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndVirtualClasses
{
    public class Student: Person
    {
        private int averageRating;

        private int numberCourse;

        public int getAverageRating { get { return averageRating; } }
        public int getNumberCourse { get { return numberCourse; } }

        public Student (string name, int age, string gender, int averageRating, int numberCourse):base (name, age, gender)
        {
            this.averageRating = averageRating;
            this.numberCourse = numberCourse;
        }
    }
}
