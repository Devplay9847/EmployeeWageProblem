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
            int EmpisFullTime = 1;
            int EmpRatePerhr = 20;
            int EmpHRS = 0;
            int EmpWAGE = 0;
            Random rand = new Random();
            int RandomCheck = rand.Next(2);
            if (RandomCheck == EmpisFullTime)
            {
                EmpHRS = 8;
            }
            else
            {
                EmpHRS = 0;
            }
            EmpWAGE = EmpHRS * EmpRatePerhr;
            Console.WriteLine("Emp wage:" + EmpWAGE);
            Console.ReadLine();
        }
    }
}
