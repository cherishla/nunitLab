using NUnit.Framework;
using uTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uTest.Tests
{
    [TestFixture()]
    public class CalculatorTests
    {
        //setup是測試自己控制，跑測試的時候才會跑，建構式也是會run，有些行為下會跑空值
        Calculator c;
        [SetUp]
        public void Init() {
            c = new Calculator();
        }

        [Test()]
        public void AddTest()
        {
            //Arrange
            var firstNum = 1;   //設定兩個要相加的變數值
            var secondNum = 2;
            var expected = 3;   //設定最後預期結果

            //Act
            //實際呼叫Class1類別中Add 函式
            var actual = c.Add(firstNum, secondNum);


            //Assert
            //確認預期結果值與實際呼叫結果值是否相等
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void minusTestTest()
        {
            //Arrange
            var firstNum = 200000000;   //設定兩個要相加的變數值
            var secondNum = 100000000;
            var expected = 100000000;   //設定最後預期結果

            //Act
            var actual = c.minusTest(firstNum, secondNum);
            //Assert
            Assert.AreEqual(expected, actual);

        }


    }
}