using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mokyklos_valdymo_sistema.Models
{
    public class PupilControl
    {
        public List<Pupil> Pupils { get; set; }

        public PupilControl(List<Pupil> pupils)
        {
            Pupils = pupils;


        }

        public void AddPupil(List<Pupil> pupil)
        {
            pupil.Add(pupil);
        }
        public List<Pupil> GetAllPupils()
        {
            return Pupils;
        }

        public List<Grade> GetPupilsGrades(Pupil pupil)
        {

            return pupil.Mark;
        }



    }
}
