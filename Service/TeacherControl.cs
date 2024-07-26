using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mokyklos_valdymo_sistema.Models;

namespace Mokyklos_valdymo_sistema.Service
{
    internal class TeacherControl
    {

        public List<Teacher> Teachers { get; set; }

        public TeacherControl(List<Teacher> teachers)
        {
            Teachers = teachers;
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public List<Teacher> GetAllTeachers()
        {
            return Teachers;
        }

        public void AddGradeFromTeacher(Teacher teacher, Grade actualGrade)
        {
            //pupil.AddGrade(actualGrade);
            teacher.AddGivenGrade(actualGrade);
        }

    }
}
