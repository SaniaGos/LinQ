using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers.Klasses
{
    enum Education
    {
        none, School, Secondary, Higher
    }
    enum Profession
    {
        none, Handyman, Engineer, Programmer, Teacher, Manager
    }
    class Worker
    {
        public int IDnumber { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public Profession Profession { get; set; }
        public Education Education { get; set; }
        public DateTime BirhtDay { get; set; }

        //public Worker()
        //{
        //    IDnumber = -1;
        //    Fname = "";
        //    Sname = "";
        //    Profession = Profession.none;
        //    Education = Education.none;
        //    DateTime = new DateTime(1900, 01, 01);
        //}

    }
}
