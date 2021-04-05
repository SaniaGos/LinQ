using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers.Klasses
{
    static class Data
    {
        public static List<Worker> Workers = new List<Worker>
        {
            new Worker {Fname = "Vasul", Sname = "Gorbatyk", BirhtDay =  new DateTime(1984, 10, 14), Education = Education.Secondary, Profession = Profession.Handyman, IDnumber = 1},
            new Worker {Fname = "Alina", Sname = "Dumud", BirhtDay =  new DateTime(1987, 09, 05), Education = Education.Higher, Profession = Profession.Manager, IDnumber = 2},
            new Worker {Fname = "Ivan", Sname = "Oleksuch", BirhtDay =  new DateTime(2005, 02, 16), Education = Education.School, Profession = Profession.none, IDnumber = 3},
            new Worker {Fname = "Volodia", Sname = "Bagriy", BirhtDay =  new DateTime(2002, 08, 12), Education = Education.Higher, Profession = Profession.Teacher, IDnumber = 4},
            new Worker {Fname = "Kolia", Sname = "Mukutun", BirhtDay =  new DateTime(1980, 06, 18), Education = Education.Higher, Profession = Profession.Programmer, IDnumber = 5},
            new Worker {Fname = "Nazar", Sname = "Babiy", BirhtDay =  new DateTime(1999, 12, 23), Education = Education.Secondary, Profession = Profession.Handyman, IDnumber = 6},
            new Worker {Fname = "Misha", Sname = "Onuskiv", BirhtDay =  new DateTime(1995, 11, 26), Education = Education.Higher, Profession = Profession.Engineer, IDnumber = 7},
            new Worker {Fname = "Oleksandr", Sname = "Popov", BirhtDay =  new DateTime(1990, 03, 30), Education = Education.Secondary, Profession = Profession.Handyman, IDnumber = 8}
        };
        public static List<Salary> Salaries = new List<Salary>
        {
            new Salary {WorkerID = 1, SalFirstHalf = 50454, SalSecondHalf  = 53445 },
            new Salary {WorkerID = 2, SalFirstHalf = 170558, SalSecondHalf  = 193875 },
            new Salary {WorkerID = 3, SalFirstHalf = 21545, SalSecondHalf  = 15545 },
            new Salary {WorkerID = 4, SalFirstHalf = 35454, SalSecondHalf  = 38745 },
            new Salary {WorkerID = 5, SalFirstHalf = 127545, SalSecondHalf  = 135056 },
            new Salary {WorkerID = 6, SalFirstHalf = 45054, SalSecondHalf  = 47545 },
            new Salary {WorkerID = 7, SalFirstHalf = 99054, SalSecondHalf  = 95125 },
            new Salary {WorkerID = 8, SalFirstHalf = 47554, SalSecondHalf  = 45713 },
        };
    }
}
