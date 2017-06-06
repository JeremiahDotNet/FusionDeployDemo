using Microsoft.AspNetCore.Mvc;
using Xunit;
using FusionDeployDemo.Controllers;

namespace FusionDeployDemo.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void HasVersion()
        {
            // arrange
            var sut = new HomeController();

            // act
            var result = sut.Index() as ViewResult;

            // assert
            Assert.NotNull(result.ViewData["Version"]);
        }
    }
}
