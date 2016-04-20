using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Should.Fluent;

namespace Sandbox.Tests
{
    public class StateTest
    {
        private State _s;

        public StateTest()
        {
            this._s = new State();
        }

        [Fact]
        public void ShouldWorkFor_a()
        {
            this._s.IsValid("a").Should().Be.True();
        }

        [Fact]
        public void ShouldWorkFor_d()
        {
            this._s.IsValid("d").Should().Be.False();
        }

        [Fact]
        public void ShouldWorkFor_ba()
        {
            this._s.IsValid("ba").Should().Be.False();
        }

        [Fact]
        public void ShouldWorkFor_ab()
        {
            this._s.IsValid("ab").Should().Be.True();
        }

        [Fact]
        public void ShouldWorkFor_abc()
        {
            this._s.IsValid("abc").Should().Be.True();
        }

        [Fact]
        public void ShouldWorkFor_abbc()
        {
            this._s.IsValid("abbc").Should().Be.True();
        }

        [Fact]
        public void ShouldWorkFor_cb()
        {
            this._s.IsValid("cb").Should().Be.False();
        }

        [Fact]
        public void ShouldWorkFor_ca()
        {
            this._s.IsValid("ca").Should().Be.False();
        }
    }
}
