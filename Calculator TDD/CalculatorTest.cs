using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Should.Fluent;
using Xunit;

namespace Sandbox.Tests
{
    public class CalculatorTest
    {
        private Calculator _calculator;

        public CalculatorTest()
        {
            this._calculator = new Calculator();
        }

        [Fact]
        public void AddShouldWorkFor0_0()
        {
            var result = this._calculator.Add(new[] {0, 0});
            result.Should().Equal(0);
        }

        [Fact]
        public void AddShouldWorkFor1_2()
        {
            var result = this._calculator.Add(new[] {1, 2});
            result.Should().Equal(3);
        }

        [Fact]
        public void AddShouldWorkFor0_0_3()
        {
            var result = this._calculator.Add(new[] {0, 0, 3});
            result.Should().Equal(3);
        }

        [Fact]
        public void AddShouldWorkFor0_1_3_4()
        {
            var result = this._calculator.Add(new[] {0, 1, 3, 4});
            result.Should().Equal(8);
        }

        [Fact]
        public void AddShouldWorkFor0_0_3_4_14()
        {
            var result = this._calculator.Add(new[] { 0, 0, 3, 4, 14});
            result.Should().Equal(21);
        }

        [Fact]
        public void AddShouldWorkFor0_0_3_4_56_2546()
        {
            var result = this._calculator.Add(new[] { 0, 0, 3, 4,56,2546, });
            result.Should().Equal(2609);
        }


    }
}

