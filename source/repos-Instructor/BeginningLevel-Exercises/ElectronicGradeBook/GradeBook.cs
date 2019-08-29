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
        private string _name;

        public string Name
        {
            get { return this._name; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                if(this._name != value)
                {
                    _name = value;
                }

            }


        }


        public List<double> Grades
        {
            get { return this.grades; }
        }

        public GradeBook()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            if(grade >= 0.0 && grade <= 100.0)
            {
                this.grades.Add(grade);
            }
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            double sum = 0.0;

            foreach (var item in grades)
            {
                stats.HighestGrade = Math.Max(item, stats.HighestGrade);
                stats.LowestGrade = Math.Min(item, stats.LowestGrade);
                sum += item;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

    }
}
