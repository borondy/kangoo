using System;
using Xunit;
using Kangoro.Core;


namespace Kangoro.Core.Test
{
    public class KangorooTests
    {

        [Fact]
        public void ReturnsErrorMessageIfPositionIsSmalerThanZero()
        {
            string result = Program.Kangoroo(-1, 2, 22, 223);
            Assert.Equal(ErrorMessage.InitialPositionToLow, result);
        }

        [Fact]
        public void ReturnsErrorMessageIfPositionIsGreaterThan10000()
        {
            string result = Program.Kangoroo(1000000, 2, 22, 223);
            Assert.Equal(ErrorMessage.InitialPositionToHigh, result);
        }

        [Fact]
        public void ReturnsErrorMessageIfVelocityIsSmalerThan1()
        {
            string result = Program.Kangoroo(1, 0, 22, 223);
            Assert.Equal(ErrorMessage.SpeedToLow, result);
        }

        [Fact]
        public void ReturnsErrorIfSecondKangorooHasSmallerInitialPosition()
        {
            string result = Program.Kangoroo(2, 2, 1, 223);
            Assert.Equal(ErrorMessage.FirstKangorooShouldHaveSmallerInitialPosition, result);
        }
        [Fact]
        public void ReturnsYESWith_0_1_0_1()
        {
            string result = Program.Kangoroo(0, 1, 0, 1);
            Assert.Equal("YES", result);
        }

        [Fact]
        public void ReturnsNoWith_0_2_0_1()
        {
            string result = Program.Kangoroo(0, 2, 0, 1);
            Assert.Equal("NO", result);
        }

        [Fact]
        public void ReturnsErrorMessageIfVelocityIsGreaterThan10000()
        {
            string result = Program.Kangoroo(0, 10003, 4, 2);
            Assert.Equal(ErrorMessage.SpeedToHigh, result);
        }

        [Fact]
        public void ReturnsYESWith_0_3_4_2()
        {
            string result = Program.Kangoroo(0, 3, 4, 2);
            Assert.Equal("YES", result);
        }

        [Fact]
        public void ReturnsNOWith_0_1_1_1()
        {
            string result = Program.Kangoroo(0, 1, 1, 1);
            Assert.Equal("NO", result);
        }

        [Fact]
        public void ReturnsYESWith_0_10_5_5()
        {
            string result = Program.Kangoroo(0, 10, 5, 5);
            Assert.Equal("YES", result);
        }

        [Fact]
        public void ReturnsNoWith_0_10_5_6()
        {
            string result = Program.Kangoroo(0, 10, 5, 6);
            Assert.Equal("NO", result);
        }
    }
}
