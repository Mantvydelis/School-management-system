using Mokyklos_valdymo_sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokyklos_valdymo_sistema.Service
{
    internal class SchoolService
    {

        public PupilControl PupilControl {  get; set; }
        
        public TeacherControl TeacherControl { get; set; }

        public SchoolService(PupilControl pupilControl, TeacherControl teacherControl)
        {
            PupilControl = pupilControl;
            TeacherControl = teacherControl;
        }

        public void AddTeacher(Teacher teacher)
        {
            TeacherControl.AddTeacher(teacher);
        }

        public void AddGrade(string pupilName, string pupilSurname, string teacherName, string teacherSurname, Grade grade)
        {

            foreach (Pupil pupil in PupilControl.Pupils)
            {
                if (pupil.Name == pupilName && pupil.Surname == pupilSurname)
                {
                    pupil.AddGrade(grade);
                }
            }

            foreach (Teacher teacher in TeacherControl.Teachers)
            {
                if (teacher.Name == pupilName && teacher.Surname == pupilSurname)
                {
                    teacher.AddGivenGrade(grade);
                }
            }
        }

    }
}
