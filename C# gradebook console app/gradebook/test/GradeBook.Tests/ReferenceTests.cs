using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void AddGrade_Test(){
            //arrange
            var book = new InMemoryBook("");
            //action
            book.AddGrade(100);
            var grades = book.GetGrades();

            //assert
            Assert.True(grades.Count >= 1);
        }
        [Fact] //attribute
        public void BookCalculatesStats()
        {
            // arange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            
            //action
            var result = book.GetStats();

            //assert
            Assert.Equal(90.5, result.High,1);
            Assert.Equal(77.3,result.Low,1);
            Assert.Equal(85.6,result.Average,1);
            Assert.Equal('B',result.Letter);
            
        }
    }
}
