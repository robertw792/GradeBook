using System;
using Xunit;
namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTest
    {
        int count = 0;
        
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;

            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello");
            Assert.Equal(3,count);

        }

        string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }

        string ReturnMessage(string message)
        {
            count++;
            return message;
        }
      
        public void String()
        {
            string name = "Rob";
            name.ToUpper();
            /*
             * this will fail, because the value can never be made uppercase due to being referenced by type
             * you'd need a new variable to make this test pass as it will copy the amended value into the variable e.g.
             * var upper = name.ToUpper();
             * Assert.Equal("ROB", upper);
            */

            Assert.Equal("ROB", name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            // arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            // assert
            Assert.Equal("Book 1", book1.Name);
        }

        [Fact]
        public void e()
        {
            var x = GetInt();

            SetInt(ref x);

            Assert.Equal(23, x);

        }

        private int GetInt()
        {
            return 3;
        }

        private void SetInt( ref int x)
        {
            x = 23;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            //constructs book object
            book = new InMemoryBook(name);
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // arrange
            var book1 = GetBook("Book 1");
            // book2 is taking value of book1 variable
            var book2 = book1;

            // assert
            Assert.Same(book1, book2);
            Assert.Equal(book1, book2);
        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }






    }
}
