using System;
using NUnit.Framework;
using FluentAssertions;
namespace TeamServicesScrubber.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var sut = new MyClass();
            var result = sut.MyMethod();
            result.Should().Be(4);
        }
    }
}
