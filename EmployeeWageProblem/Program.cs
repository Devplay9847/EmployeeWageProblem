using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Parttime = 1;
            int Fulltime = 2;
            int EmpRatePERHR = 20;
            int Emphr = 0;
            int Empwage = 0;
            Random random = new Random();
            int RandomCheck = random.Next(0, 2);
            if (RandomCheck == Parttime)
            {
                Emphr = 4;
            }
            else if (RandomCheck == Fulltime)
            {
                Emphr = 8;
            }
            else
            {
                Emphr = 0;
            }
            Empwage = Emphr * EmpRatePERHR;
            Console.WriteLine("EMP wage :" + Empwage);
            Console.ReadLine();
        }
    }
}
