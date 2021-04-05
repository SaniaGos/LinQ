using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers.Klasses;


namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            var Old35 = Data.Workers.Select(w => w).Where(d => d.BirhtDay.Year < (DateTime.Now.Year - 35)); // старше 36 років
            foreach (Worker item in Old35)
            {
                Console.WriteLine($"{item.Fname}  {item.Sname}");
            }
            Console.WriteLine();

            var maxSalarySecondHalfYear = Data.Salaries.Select(s => s).Max(d => d.SalSecondHalf);  // максимальна зарплата другого півріччя
            foreach (Salary item in Data.Salaries)
            {
                if (maxSalarySecondHalfYear == item.SalSecondHalf) Console.WriteLine(item.WorkerID);
            }
            Console.WriteLine("\n\n");

            // var average = Data.Salaries.Select(s => s).Average(s => s.SalFirstHalf + s.SalSecondHalf);
            // працівники з меншою середньою зарплатою
            var join = Data.Workers.Join(Data.Salaries, w => w.IDnumber, s => s.WorkerID, (w, s) =>
                        new
                        {
                            FName = w.Fname,
                            SName = w.Sname,
                            Education = w.Education,
                            Profession = w.Profession,
                            Salary = s.SalFirstHalf + s.SalSecondHalf
                        }).Where(s => s.Salary < (Data.Salaries.Select(a => a).Average(a => a.SalFirstHalf + a.SalSecondHalf)));

            foreach (var item in join)
            {
                Console.WriteLine($"{item.FName} {item.SName}  {item.Education}  {item.Profession}");
            }
            Console.ReadLine();
        }
    }
}
