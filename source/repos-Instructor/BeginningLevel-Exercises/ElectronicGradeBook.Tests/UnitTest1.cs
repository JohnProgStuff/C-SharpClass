using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectronicGradeBook.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatTheListOfGradesIsNotNull()
        {
            GradeBook book = new GradeBook();
            Assert.IsNotNull(book.Grades);
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
        public void TestPassByValue()
        {
            GradeBook book = new GradeBook();
            book.Name = "Not Set Yet";
            SetName(book);
            Assert.AreEqual("Another Name", book.Name);
        }


    }
}
