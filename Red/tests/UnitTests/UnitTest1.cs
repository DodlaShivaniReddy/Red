using System;
using Xunit;

namespace UnitTets
{
    public class UnitTest1
    {

        [Fact]
        public void SubstractionOfNumb()
        {
            var expected =3 ;
            var a = 5;
            var b = 2;
            var actual = Sub(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6,10,4)]
        [InlineData(10,20,10)]
        [InlineData(4,6,2)]
        public void SubstractionTest(int exp,int n1,int n2)
        {
            Assert.Equal(exp,Sub(n1,n2));
        }

        int Sub(int x, int y)
        {
            return x - y;
        }
    }
}

       