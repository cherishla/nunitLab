using NUnit.Framework;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using System.Web.Mvc;

namespace WebApplication1.Controllers.Tests
{
    [TestFixture()]
    public class HomeControllerTests
    {
        [Test()]
        public void IndexTest()
        {
            //arrangr
            var c = new HomeController();

            //act
            var actual = c.Index() as ViewResult;
            string actual2 = actual.ViewData["Title"] as string;
            //assert
            actual.Should().BeOfType<ViewResult>(because: "目前只回傳viewresult");
            actual2.Should().Be("Home Page", because: "首頁設定為Home Page");
        }
    }
}