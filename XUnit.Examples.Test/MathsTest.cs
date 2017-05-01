using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnit.Examples.Test
{
    public class MathsTest
    {
        Maths obj;
        public MathsTest()
        {
            obj = new Maths();
        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, obj.Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, obj.Add(2, 2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(obj.IsOdd(value));
        }


    }
}
