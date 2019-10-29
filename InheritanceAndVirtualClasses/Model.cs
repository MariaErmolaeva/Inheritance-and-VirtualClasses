using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndVirtualClasses
{
    public class Model : IModel
    {
        private List<Person> personArray;

        private int indexArray;
       

        private string[] nameMale = new string[10] { "Mike", "Adam", "Arthur", "Tom", "Nikolas", "Isaak", "Nik", "Gregor", "Fred", "John" };
        private string[] nameFemale = new string[10] { "Kile", "Alisa", "Maggie", "Lisa", "Marta", "Kris", "Kate", "Rose", "Sara", "Emily" };
        private string[] gender = new string[2] { "Male", "Female" };

        private string[] departament = new string[4] {"biological","physical","geographical","chemical" };
        private string[] position = new string[5] { "teacher", "dean", "deputy dean", "Ph. D", "candidate" };

        private string[] profession = new string[4] {"electric", "secretary", "cleaner", "engineer" };

        public int index { set { indexArray = value; } }

        public int countArray { get { return personArray.Count(); } }
        public Person person { get { return personArray[indexArray]; } }

        public Model(int countStudent, int countTeacher, int countEmployee)
        {
            Random rnd = new Random();

            CreateStudent(countStudent, rnd);
            CreateTeacher(countTeacher, rnd);
            CreateEmployee(countEmployee, rnd);
        }


        private void CreateStudent (int countStudent, Random rnd)
        {
            for (int i = 0; i < countStudent; i++)
            {
                string male = gender[rnd.Next(0, 1)];
                if (male == gender[0])
                    personArray.Add(new Student(nameMale[rnd.Next(0, 9)], rnd.Next(18, 25), gender[0], rnd.Next(1, 5), rnd.Next(1, 4)));
                else
                    personArray.Add(new Student(nameFemale[rnd.Next(0, 9)], rnd.Next(18, 25), gender[1], rnd.Next(1, 5), rnd.Next(1, 4)));
            }
        }

        private void CreateTeacher(int countTeacher, Random rnd)
        {
            for (int i = 0; i < countTeacher; i++)
            {
                string male = gender[rnd.Next(0, 1)];
                if (male == gender[0])
                    personArray.Add(new Teacher(nameMale[rnd.Next(0, 9)], rnd.Next(20, 60), gender[0], position[rnd.Next(0,4)], departament[rnd.Next(0,3)]));
                else
                    personArray.Add(new Teacher(nameFemale[rnd.Next(0, 9)], rnd.Next(20, 60), gender[0], position[rnd.Next(0, 4)], departament[rnd.Next(0, 3)]));
            }
        }

        private void CreateEmployee(int countEmployee, Random rnd)
        {
            for (int i = 0; i < countEmployee; i++)
            {
                string male = gender[rnd.Next(0, 1)];
                if (male == gender[0])
                    personArray.Add(new Employee(nameMale[rnd.Next(0, 9)], rnd.Next(20, 60), gender[0], profession[rnd.Next(0,3)], rnd.Next(1,15)));
                else
                    personArray.Add(new Employee(nameFemale[rnd.Next(0, 9)], rnd.Next(20, 60), gender[0], profession[rnd.Next(0, 3)], rnd.Next(1, 15)));
            }
        }
    }
}
