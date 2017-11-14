using System.Collections.Generic;

namespace Organization
{
    public class Manager
    {
        public Project oProject;

        public Manager()
        {
            oProject = new Project(this);
        }

        //Aggregation relationship
        public List<Worker> Workers = new List<Worker>();
        public void Logon(SwipeCard obj)
        {
            obj.Swipe(this);
        }

        public string GetManagerName()
        {
            return "Shiv";
        }

        public double Salary = 10;

        public void HowisTheManager(bool Good)
        {
            if (Good)
            {
                oProject.Success = true;
            }
            else
            {
                oProject.Success = false;
            }
        }

    }

    public class SwipeCard
    {
        public void Swipe(Manager obj)
        {
            // goes and swipes the manager
        }

        public string MakeofSwipecard()
        {
            return "c001";
        }

    }

    public class Worker
    {
        public string Wrokername = "";
    }

    public class Project
    {

        private Manager oManager;
        private bool IsSuccess = false;

        public bool Success
        {
            get { return IsSuccess; }
            set
            {
                IsSuccess = value;
                if (value)
                {
                    oManager.Salary++;
                }
                else
                {
                    oManager.Salary--;
                }
            }
        }

        public Project(Manager obj)
        {
            oManager = obj;
        }
    }
}
    
    




