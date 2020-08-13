using System;
using Xunit;

// how do you force a fail?

namespace GradeBook.Tests
{   

    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTests
    {
        [Fact]
        public void WriteLogDelegateCanPointToMethod(){
            WriteLogDelegate log;
            
            log = new WriteLogDelegate(ReturnMessage);    
            
            var result = log("Hello");
            Assert.Equal("Hello",result);
        } 

        string ReturnMessage(string message){
            return message;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes(){
            //arrange
            string name = "Thomas";
            //action
            var upper = MakeUppercase(name);
            //assert
            Assert.Equal("THOMAS",upper);
            Assert.Equal("Thomas",name);
        }

        private string MakeUppercase(string parameter){
          return parameter.ToUpper();
        }

        [Fact]
        public void ValuTypesAlsoPassByValue(){
            //arrange
            var x = GetInt();
            //action
            SetInt(ref x);
            //assert
            //Assert.Equal(3,x);
            Assert.Equal(42,x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef(){
            //arrange
            var book1 = GetBook("Book 1");
            //action
            GetBookSetNameRef(ref book1,"Moby Dick"); //see also out parameter
            //assert
            Assert.Equal("Moby Dick",book1.Name);
        }

        private void GetBookSetNameRef(ref Book book, string name) //out parameter requires output
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue(){
            //arrange
            var book1 = GetBook("Book1");
            //action
            GetBookSetName(book1,"Moby Dick");
            //assert
            Assert.NotEqual("Moby Dick", book1.Name);
            //my guess is this will fail
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromRef(){
            //arrange
            var book1 = GetBook("Book 1");
            //action
            SetName(book1, "Moby Dick");
            //assert
            Assert.Equal("Moby Dick",book1.Name);
        }   

        private void SetName(Book book, string name){
            book.Name = name; 
        }

        [Fact] //attribute
        public void GetBookReturnDifferentObjects()
        {
            // arange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            
            //action
            

            //assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1,book2);

            
        }
        [Fact]
        public void TwoVarsCanRefSameObj()
        {
            // arange
            var book1 = GetBook("Book 1");
            var book2 = book1;
            
            //action
            

            //assert
            Assert.Same(book1,book2);
            
        }

        Book GetBook(string name){
            return new Book(name);
        }
    }
}
