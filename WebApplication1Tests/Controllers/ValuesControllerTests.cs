using NUnit.Framework;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using System.Web.Http.Results;

namespace WebApplication1.Controllers.Tests
{
    [TestFixture()]
    public class ValuesControllerTests
    {
        ValuesController c;
        [SetUp]
        public void Init() {
            c = new ValuesController();

        }
        [Test()]
        public void Get_所有資料()
        {
            //arrange
            var except = 2;
            //act
            var actual = c.Get() as IEnumerable<string>;
            //assert
            actual.Should().HaveCount(except, because: "有兩筆資料");
        }
        [Test()]
        public void Get_所有資料ByID()
        {
            //arrange
            var id = 1;
            var except = "value" + id;
            //act
            var actual = c.Get(id);
            //assert
            actual.Should().Be(except, because: "value + id");

        }

        [Test()]
        public void Post_測試一個空物件()
        {
            var actual = c.Post(new ToDoItem());
            actual.Should().BeOfType<BadRequestResult>(because: "測試一個空物件");
        }
    }
}


