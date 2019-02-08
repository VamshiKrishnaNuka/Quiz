using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Stationary_1()
        {
            var expected = 10;
            var book = 1;
            var price = 10;
            var actual = Stationary(book, price);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(3,3,1)]
        [InlineData(15,5,3)]
        [InlineData(18,9,2)]
        public void Grade_1(int exp,int sub, int points)
        {
            Assert.Equal(exp,Grade(sub,points));
        }
               
        int Stationary(int book, int price)
        {
            return book * price;
        }

        int Grade(int sub, int points)
        {
            return sub * points;
        }
    }
}