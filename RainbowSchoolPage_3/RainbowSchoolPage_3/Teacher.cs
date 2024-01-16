using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolPage_3
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }

        public Teacher(string Teaname, string Teaclass, string Teasection)
        {
            Name = Teaname;
            Class = Teaclass;
            Section = Teasection;
        }
    }
}
