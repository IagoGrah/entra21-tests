using System;
using Xunit;

namespace entra21_tests
{
    public class ProgramTest
    {
        [Fact]
        public void Test1()
        {
            var result = Program.Check(6,4);
            Assert.Equal("greater", result);
            Assert.NotEqual("lesser", result);
        }

        [Fact]
        public void Test2()
        {
            var result = Program.Check(3,3);
            Assert.Equal("equal", result);
        }
    }
}
