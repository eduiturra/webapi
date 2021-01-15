using NUnit.Framework;
using Moq;
using webapi.api.Controllers;
using Microsoft.Extensions.Logging;

namespace webapi.test
{
    public class Tests
    {
        private  WeatherForecastController controller;
        private Mock<ILogger<WeatherForecastController>> log;
        [SetUp]
        public void Setup()
        {
            log = new Mock<ILogger<WeatherForecastController>>();
            controller = new WeatherForecastController(log.Object);
        }

        [Test]
        public void Test1()
        {
            var action = controller.Get() as string;
            Assert.AreEqual(action, "Running...");
        }
    }
}