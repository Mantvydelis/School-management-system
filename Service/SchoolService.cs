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



        public void AddPupil(Pupil pupil)
        {
            PupilControl.AddPupil(pupil);
        }

        public List<Pupil> GetAllPupils()
        {
            return PupilControl.GetAllPupils(); 
            
        }

        public List<Teacher> GetAllTeachers()
        {
            TeacherControl.GetAllTeachers();
            return TeacherControl.Teachers;
        }

        public List<Grade> GetPupilsGrades(string pupilsName, string pupilsSurname)
        {
            foreach (Pupil pupil in PupilControl.Pupils)
            {
                if (pupil.Name == pupilsName && pupil.Surname == pupilsSurname)
                {
                    return PupilControl.GetPupilsGrades(pupil);
                    
                }
            }
            return null;

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
                if (teacher.Name == teacherName && teacher.Surname == teacherSurname)
                {
                    teacher.AddGivenGrade(grade);
                }
            }
        }

    }
}
