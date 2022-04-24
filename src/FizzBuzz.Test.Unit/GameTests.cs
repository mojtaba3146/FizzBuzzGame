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
        public void Shoud_Divisible_By_3()
        {
            int num = 3;

            var expected = _sut.FBGame(num);

            expected.Should().Be("fizz");
        }
    }
}
