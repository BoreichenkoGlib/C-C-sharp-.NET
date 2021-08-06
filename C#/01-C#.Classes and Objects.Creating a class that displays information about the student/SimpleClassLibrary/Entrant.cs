using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary
{
    public class Entrant
    {
        private string name;
        public string Name { get => name; set => name = value; }
        private string idNum;
        public string IdNum { get => idNum; set => idNum = value; }
        private int budget;
        public int Budget { get => budget; set => budget = value; }
        private double coursePoints;
        public double CoursePoints { get => coursePoints; set => coursePoints = value; }
        private double avgPoints;
        public double AvgPoints { get => avgPoints; set => avgPoints = value; }
        private double choice;
        public double Choice { get => choice; set => choice = value; }
        public ZNO[] ZNOResults;
        public Entrant(string name, string idnum, double coursepoints, double avgpoints, int size, int budget, int choice)
        {
            Name = name;
            IdNum = idnum;
            CoursePoints = coursepoints;
            AvgPoints = avgpoints;
            ZNOResults = new ZNO[size];
            Budget = budget;
            Choice = choice;
        }
        public void BudgetAll(int typePayment)
        {
            switch (choice)
            {
                case 1:
                     BudgetMonth(); break;
                case 2:
                    BudgetYear(); break;
                case 3:
                    BudgetAll(); break;
            }
        }
        public int budgetyear;
        public int budgetall;
        public int budgetmonth;
        public void BudgetMonth()
        {
            budgetmonth = budget;
            budgetall = budget * 40;
            budgetyear = budget * 10;
        }
        public void BudgetYear()
        {
            budgetyear = budget;
            budgetmonth = budget / 10;
            budgetall = budgetmonth * 40;
        }
        public void BudgetAll()
        {
            budgetall = budget;
            budgetmonth = budget / 40;
            budgetyear = budgetmonth * 10;
        }
        public double GetCompMark()
        {
            if (ZNOResults.Length >= 3)
            {
                double k = 0.05 * CoursePoints + 0.10 * AvgPoints + ZNOResults[0].Points * 0.25 + ZNOResults[1].Points * 0.4 + ZNOResults[2].Points * 0.2;
                return k;
            }
            else
                return 0;
        }
        public string GetBestSubject()
        {
            double max = int.MinValue;
            string str = " ";
            for (int i = 0; i < ZNOResults.Length; i++)
            {
                if (ZNOResults[i].Points > max)
                {
                    max = ZNOResults[i].Points;
                    str = ZNOResults[i].Subject;
                }
            }
            return str;
        }
        public string GetWorstSubject()
        {
            double min = int.MaxValue;
            string str = " ";
            for (int i = 0; i < ZNOResults.Length; i++)
            {
                if (ZNOResults[i].Points < min)
                {
                    min = ZNOResults[i].Points;
                    str = ZNOResults[i].Subject;
                }
            }
            return str;
        }

    }
}
