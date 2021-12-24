using FluentAssertions;
using GymScheduler.Commons.Extensions;
using Xunit;

namespace GymScheduler.Commons.Tests
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData("  ", false)]
        [InlineData("test", false)]
        public void IsNullOrEmpty_ValidatesStringsCorrectly(string value, bool expectedResult)
        {
            value.IsNullOrEmpty().Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData("  ", true)]
        [InlineData("test", false)]
        public void IsNullOrWhitespace_ValidatesStringsCorrectly(string value, bool expectedResult)
        {
            value.IsNullOrWhitespace().Should().Be(expectedResult);
        }
    }
}
