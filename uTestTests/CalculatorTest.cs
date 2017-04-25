using NUnit.Framework;
using uTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Ploeh.AutoFixture;

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
            var fixture = new Fixture();
            //建立一筆資料
            var b = fixture.Create<ToDoItem>();
            var e = fixture.CreateMany<ToDoItem>(20);

            var d = fixture.Build<ToDoItem>()
                .With(x => x.id, 1)
                .With(x => x.description, "123")
                .With(x => x.isExit, false)
                .With(x => x.datetime, new DateTime())
                .Create();
            //Act
            //實際呼叫Class1類別中Add 函式
            var actual = c.Add(firstNum, secondNum);


            //Assert
            //確認預期結果值與實際呼叫結果值是否相等
            actual.Should().Be(expected, because: "我覺得這是對的");

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
            actual.Should().Be(expected, because: "我覺得這是對的");


        }

        public class ToDoItem
        {
            public int id { get; set; }
            public string description { get; set; }
            public bool isExit { get; set; }
            public DateTime datetime { get; set; }
            public string[] stringList { get; set; }
        }

    }
}