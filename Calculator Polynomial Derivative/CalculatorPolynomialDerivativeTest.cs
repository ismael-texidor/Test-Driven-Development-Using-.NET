using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Should.Fluent;

namespace Sandbox.Tests
{
    // 1 [1]
    // 2 [2]
    // 1 + 1*x [1, 1]
    // 2*x^0 + 3*x^1 + 4*x^2 [2, 3, 4]
    // 2*x^0 + 3*x^1 + 0*x^3 + 4*x^3 [2, 3, 0, 4]
    // [0] 0
    // [1, 2, 0] 1 
    // [0, 3] 3x
    public class CalculatorPolynomialDerivativeTest
    {
        private CalculatorPolynomialDerivative _calculator;

        public CalculatorPolynomialDerivativeTest()
        {
            this._calculator = new CalculatorPolynomialDerivative();
        }

        [Fact]
        public void DerivePolynomialShouldWorkFor0()
        {
            var result = this._calculator.DerivePolynomial(new[] { 0 });

            result.Should().Equal(new[] { 0 });
        }

        [Fact]
        public void DerivePolynomialShouldWorkFor1()
        {
            var result = this._calculator.DerivePolynomial(new[] { 1 });

            result.Should().Equal(new[] { 0 });
        }

        [Fact]
        public void DerivePolynomialShouldWorkFor0_1()
        {
            var result = this._calculator.DerivePolynomial(new[] { 0, 1 });

            result.Should().Equal(new[] { 1 });
        }

        [Fact]
        public void DerivePolynomialShouldWorkFor0_2()
        {
            var result = this._calculator.DerivePolynomial(new[] { 0, 2 });

            result.Should().Equal(new[] { 2 });
        }

        [Fact]
        public void DerivePolynomialShouldWorkFor0_0_1()
        {
            var result = this._calculator.DerivePolynomial(new[] { 0, 0, 1 });

            result.Should().Equal(new[] { 0, 2 });
        }

        [Fact]
        public void DerivePolynomialShouldWorkFor0_0_2()
        {
            var result = this._calculator.DerivePolynomial(new[] { 0, 0, 2 });

            result.Should().Equal(new[] { 0, 4 });
        }

        [Fact]
        public void DerivePolynomialShouldWorkFor0_0_3()
        {
            var result = this._calculator.DerivePolynomial(new[] { 0, 0, 3 });

            result.Should().Equal(new[] { 0, 6 });
        }

        [Fact]
        public void DerivePolynomialShouldWorkFor0_4_3()
        {
            var result = this._calculator.DerivePolynomial(new[] { 0, 4, 3 });

            result.Should().Equal(new[] { 4, 6 });
        }

        [Fact]
        public void DerivePolynomialShouldWorkFor0_0_0_1()
        {
            var result = this._calculator.DerivePolynomial(new[] { 0, 0, 0, 1 });

            result.Should().Equal(new[] { 0, 0, 3 });
        }

        [Fact]
        public void DerivePolynomialShouldWorkFor1_2_3_4_5()
        {
            var result = this._calculator.DerivePolynomial(new[] { 1, 2, 3, 4, 5 });

            result.Should().Equal(new[] { 2, 6, 12, 20 });
        }
    }
}
