using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGradeBook
{
    public class GradeBook
    {
        private List<double> grades;
        private string m_name;

        public string Name
        {
            get { return this.m_name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    this.m_name = "Jon Smith";
                }
                else
                {
                    this.m_name = value;
                }
            }
        }

        public List<double> Grades
        {
            get { return this.grades; }
        }

        //Constructor
        public GradeBook()
        {
            grades = new List<double>();
        }

        // methods
        public void AddGrade(double grade)
        {
            if (grade >= 0.0 & grade <= 100.0)
            {
                grades.Add(grade);
            }
            else
            {
                //Console.WriteLine("Value must be a valid grade");
            }
        }
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics gradeStats = new GradeStatistics();
            
            gradeStats.AverageGrade = grades.Average();
            gradeStats.HighestGrade = grades.Max();
            gradeStats.LowestGrade = grades.Min();

            return gradeStats;
        }
    }
}
