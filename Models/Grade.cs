using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokyklos_valdymo_sistema.Models
{
    public class Grade
    {
        public string Topic { get; set; }
        public int CompletionDate { get; set; }

        public int ActualGrade { get; set; }

        public Grade (string topic, int comletiondate, int actualGrade)
        {
            Topic = topic;
            CompletionDate = comletiondate;
            ActualGrade = actualGrade;
        }
    }


}
