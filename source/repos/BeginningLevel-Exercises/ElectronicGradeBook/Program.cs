using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook gb = new GradeBook();
            GradeStatistics stats = new GradeStatistics();
            try
            {
                gb.AddGrade(95.5);
                gb.AddGrade(45);
                gb.AddGrade(95);
                gb.AddGrade(77);
                gb.AddGrade(68);
                gb.AddGrade(92);
                gb.AddGrade(88);
                gb.AddGrade(66);
                gb.AddGrade(100);
                gb.AddGrade(95);
                gb.AddGrade(100.5);
                gb.AddGrade(55);
                gb.AddGrade(95.45);
                gb.AddGrade(-5.5);


            }
            catch (Exception e)
            {
                Console.WriteLine("Grades entered must be numbers. " + e);
            }

            stats = gb.ComputeStatistics();
            Console.WriteLine("Average grade: " + stats.AverageGrade);
            Console.WriteLine("Highest grade: " + stats.HighestGrade);
            Console.WriteLine("Lowest grade: " + stats.LowestGrade);
        }
    }
}
