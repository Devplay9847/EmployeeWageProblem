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
            int Empispresent = 1;
            Random rand = new Random();
            int RandomCheck = rand.Next(2);
            if (Empispresent == RandomCheck)
            {
                Console.WriteLine("Employee is present ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee is abscent");
                Console.ReadLine();
            }
        }
    }
}
