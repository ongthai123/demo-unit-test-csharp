using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace demo_unit_test_csharp
{
    [TestFixture]
    //đặt vào đầu class chứa các unit test, đánh dấu đây là một bộ các unit test.
    public class CalculatorTest
    {
        private Calculator _cal;

        [SetUp]
        //để đánh dấu hàm setup. Hàm này sẽ được chạy vào đầu mỗi unit test.
        public void SetUp()
        {
            _cal = new Calculator();
        }

        [Test]
        // để đánh dấu hàm bên dưới là một unit test. Nhiều khi bạn viết unit test xong nhưng không thấy hiện unit test lên là do quên annotation này nhé.
        public void OnePlusOneEqualsTwo()
        {
            Assert.AreEqual(2, _cal.Add(1, 1));
        }

        [Test]
        public void TwoPlusTwoEqualsFour()
        {
            Assert.AreEqual(4, _cal.Add(2, 2));
        }

        [Test]
        public void FourPlusOneEqualsFive()
        {
            Assert.AreEqual(5, _cal.Add(4, 1));
        }
    }
}
