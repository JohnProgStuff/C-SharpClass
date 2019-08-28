using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGradeBook
{
    public class GradeStatistics
    {
        private double averageGrade;
        private double highestGrade;
        private double lowestGrade;

        public double AverageGrade
        {
            get { return this.averageGrade; }
            set { this.averageGrade = value; }
        }

        public double HighestGrade
        {
            get { return this.highestGrade; }
            set { this.highestGrade = value; }
        }

        public double LowestGrade
        {
            get { return this.lowestGrade; }
            set { this.lowestGrade = value; }
        }

        public GradeStatistics()
        {
            averageGrade = 0.0;
            highestGrade = 0.0;
            lowestGrade = 0.0;
        }
    }
}
