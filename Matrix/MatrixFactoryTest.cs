using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Should.Fluent;

namespace Sandbox.Tests
{
    public class MatrixFactoryTest
    {
        private MatrixFactory _mf;

        public MatrixFactoryTest()
        {
            this._mf = new MatrixFactory();
        }

        [Fact]
        public void ShouldWorkFor1()
        {
            var m = this._mf.Parse("[[1]]");

            m.Get(0, 0).Should().Equal(1);
        }

        [Fact]
        public void ShouldWorkFor11()
        {
            var m = this._mf.Parse("[[11]]");

            m.Get(0, 0).Should().Equal(11);
           
        }

        [Fact]
        public void ShouldWorkFor115()
        {
            var m = this._mf.Parse("[[115]]");

            m.Get(0, 0).Should().Equal(115);

        }

        [Fact]
        public void ShouldWorkFor1_2()
        {
            var m = this._mf.Parse("[[1,2]");

            m.Get(0, 0).Should().Equal(1);
            m.Get(1, 0).Should().Equal(2);

        }

        [Fact]
        public void ShouldWorkFor11_12()
        {
            var m = this._mf.Parse("[[11,12]");

            m.Get(0, 0).Should().Equal(11);
            m.Get(1, 0).Should().Equal(12);

        }

        [Fact]
        public void ShouldWorkFor10_2_3()
        {
            var m = this._mf.Parse("[[10,2,3]]");

            m.Get(0, 0).Should().Equal(10);
            m.Get(1, 0).Should().Equal(2);
            m.Get(2, 0).Should().Equal(3);
        }

        [Fact]
        public void ShouldWorkFor1_2_3_4()
        {
            var m = this._mf.Parse("[[1,2,3,4]]");

            m.Get(0, 0).Should().Equal(1);
            m.Get(1, 0).Should().Equal(2);
            m.Get(2, 0).Should().Equal(3);
            m.Get(3, 0).Should().Equal(4);
        }

        [Fact]
        public void ShouldWorkFor1And2()
        {
            var m = this._mf.Parse("[[1],[2]]");

            m.Get(0, 0).Should().Equal(1);
            m.Get(0, 1).Should().Equal(2);
        }

        [Fact]
        public void ShouldWorkFor10And20()
        {
            var m = this._mf.Parse("[[10],[20]]");

            m.Get(0, 0).Should().Equal(10);
            m.Get(0, 1).Should().Equal(20);
        }

        [Fact]
        public void ShouldWorkFor10_1And20_2()
        {
            var m = this._mf.Parse("[[10,1],[20,2]]");

            m.Get(0, 0).Should().Equal(10);
            m.Get(0, 1).Should().Equal(20);
            m.Get(1, 0).Should().Equal(1);
            m.Get(1, 1).Should().Equal(2);
        }

        [Fact]
        public void ShouldWorkFor10_1_6And20_2_5()
        {
            var m = this._mf.Parse("[[10,1,6],[20,2,5]]");

            m.Get(0, 0).Should().Equal(10);
            m.Get(0, 1).Should().Equal(20);
            m.Get(1, 0).Should().Equal(1);
            m.Get(1, 1).Should().Equal(2);
            m.Get(2, 0).Should().Equal(6);
            m.Get(2, 1).Should().Equal(5);
        }

        [Fact]
        public void ShouldWorkFor10_1_6And20_2_5And30_3_11()
        {
            var m = this._mf.Parse("[[10,1,6],[20,2,5],[30,3,11]]");

            m.Get(0, 0).Should().Equal(10);
            m.Get(0, 1).Should().Equal(20);
            m.Get(0, 2).Should().Equal(30);
            m.Get(1, 0).Should().Equal(1);
            m.Get(1, 1).Should().Equal(2);
            m.Get(1, 2).Should().Equal(3);
            m.Get(2, 0).Should().Equal(6);
            m.Get(2, 1).Should().Equal(5);
            m.Get(2, 2).Should().Equal(11);
        }
    }
}
