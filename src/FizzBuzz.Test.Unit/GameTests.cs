using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using FluentAssertions;
using Xunit;

namespace FizzBuzz.Test.Unit
{
    public class GameTests
    {
        private readonly BuzzFizz _sut;

        public GameTests()
        {
            _sut = new BuzzFizz();
        }

        [Fact]
        public void IF_Divisible_By_3_Say_Fizz()
        {
            int num = 3;

            var expected = _sut.GameCheckDivisible(num);

            expected.Should().Be("fizz");
        }

        [Fact]
        public void IF_Divisible_By_5_Say_Buzz()
        {
            int num = 5;

            var expected = _sut.GameCheckDivisible(num);

            expected.Should().Be("buzz");
        }

        [Fact]
        public void IF_Divisible_By_3_And_5_Say_FizzBuzz()
        {
            int num = 15;

            var expected = _sut.GameCheckDivisible(num);

            expected.Should().Be("FizzBuzz");
        }
    }
}
