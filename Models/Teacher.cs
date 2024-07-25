using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokyklos_valdymo_sistema.Models
{
    internal class Teacher
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Subject { get; set; }

        public List<Grade> GivenGrades { get; set; }

        public Teacher(string name, string surname, string subject, List<Grade> givenGrades)
        {
            Name = name;
            Surname = surname;
            Subject = subject;
            GivenGrades = givenGrades;
        }

        public string GetInfo()
        {
            return Name + " " + Surname + " Subject - " + Subject;
        }

        public void AddGivenGrade(Grade grade)
        {
            GivenGrades.Add(grade);
        }

        public List<Grade> GetAllTeacherGrades (Teacher teacher)
        {
            return teacher.GivenGrades;
        }

    }

}
