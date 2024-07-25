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
        public string Class { get; set; }
        public List<Grade> Grades { get; set; }

        public Pupil(string name, string surname, int age, string clas)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Class = clas;
            Grades = new List<Grade>();
        }

        public string GetInfo()
        {
            string allGradesString = "";

            foreach (var grade in Grades)
            {
                allGradesString += grade.ActualGrade.ToString() + " ";

            }

            return Name + " " + Surname + " " + Age + " " + Class + " " + allGradesString;

        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);

        }







    }
}
