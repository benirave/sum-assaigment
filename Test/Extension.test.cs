using CloudTools_Assaigment;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void SUM_Test_1()
        {
            var myNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = myNumbers.Sum();
            result.Should().Be(55);
        }
    }
}
