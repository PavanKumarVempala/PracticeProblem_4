using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolPage_3
{
    public class Subject
    {
        public string Name { get; set; }
        public string Subjectcode { get; set; }
        public string Teacher { get; set; }
        public Subject(string Subname, string Subcode, string Subteacher)
        {
            Name = Subname;
            Subjectcode = Subcode;
            Teacher = Subteacher;
        }
    }
}
