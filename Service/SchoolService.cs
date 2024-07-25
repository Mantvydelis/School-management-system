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
    }
}
