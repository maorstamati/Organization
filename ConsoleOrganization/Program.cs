using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organization;

namespace ConsoleOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = Boolean.Parse(args[0]);

            Manager objManager = new Manager();

            SwipeCard objSwipeCard = new SwipeCard();

            Project obj = new Project(objManager);

            System.Console.WriteLine("Initial Salary of Manager is: {0}", objManager.Salary);
            objManager.HowisTheManager(success);

            if (success)
            {
                System.Console.WriteLine("Manager Salary after project Success is: {0}", objManager.Salary);
            }
            else
            {
                System.Console.WriteLine("Manager Salary after project Failure is: {0}", objManager.Salary);
            }
            System.Console.WriteLine();

        }
    }
}
