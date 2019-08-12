using System;
using FluentAssertions;
using helloWorld.Core.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace helloWorld.UnitTests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void ShouldGetHomeControllerValues()
        {
            var controller = new HomeController();
            var actual = controller.Get().Value;
            actual.Should().Be("Get Hello World!");
        }
        [TestMethod]
        public void ShouldPutHomeControllerValues()
        {
            var controller = new HomeController();
            var guid = Guid.NewGuid();
            var actual = controller.Put($"{guid:N}").Value;
            actual.Should().Be($"Put Hello World! - {guid:N}");
        }
        [TestMethod]
        public void ShouldPostHomeControllerValues()
        {
            var controller = new HomeController();
            var actual = controller.Post("myValue").Value;
            actual.Should().Be("Post Hello World! - myValue");
        }
    }
}
