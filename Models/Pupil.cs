using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokyklos_valdymo_sistema.Models
{
    public class Pupil
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
        public int Class { get; set; }
        public List<Grade> Grades { get; set; }

        public Pupil(string name, string surname, int age, int clas, List<Grade> grades)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Class = clas;
            Grades = grades;
        }

        public string GetInfo()
        {
            return Name + " " + Surname + " " + Age + " " + Class + " " + Grades;

        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);

        }







    }
}
