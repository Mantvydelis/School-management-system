using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Mokyklos_valdymo_sistema.Models;

namespace Mokyklos_valdymo_sistema.Service
{
    public class PupilControl
    {
        public List<Pupil> Pupils { get; set; }

        public PupilControl(List<Pupil> pupils)
        {
            Pupils = pupils;


        }

        public void AddPupil(Pupil pupil)
        {


            Pupils.Add(pupil);




        }
        public List<Pupil> GetAllPupils()
        {
            return Pupils;
        }

        public List<Grade> GetPupilsGrades(Pupil pupil)
        {

            return pupil.Grades;
        }
    }
}
