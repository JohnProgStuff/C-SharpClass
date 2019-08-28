using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicGradeBook;

namespace ElectronicGradebook.Test
{


    /*
     * You must connect the ElectronicGradeBook Project to this Unit test project by right
     * clicking on the References option in the solution explorer under this project and click
     * Add Reference, Then select the project you want to connect and hit ok.
     */
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatTheListOfGradesIsNotNull()
        {
            GradeBook gradeBook = new GradeBook();
            Assert.IsNotNull(gradeBook.Grades);
        }

        [TestMethod]
        public void TestComputeStatistics()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(77);
            book.AddGrade(88);
            book.AddGrade(99);
            
            GradeStatistics stats = new GradeStatistics();

            stats = book.ComputeStatistics();

            Assert.AreEqual(88, stats.AverageGrade);
            Assert.AreEqual(99, stats.HighestGrade);
            Assert.AreEqual(77, stats.LowestGrade);
        }

        private void SetName(GradeBook book)
        {
            book.Name = "Another Name";
        }


        [TestMethod]
        public void testPassByValue()
        {
            GradeBook book = new GradeBook();
            book.Name = "Not set yet";
            SetName(book);
            Assert.AreEqual("Another Name", book.Name);
        }
    }
}
