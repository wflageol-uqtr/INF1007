using DecoderWebServer.Server.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoderWebServer.Tests
{
    [TestClass]
    public class DecoderControllerTests
    {
        private DecoderController controller;

        [TestInitialize]
        public void Setup()
        {
            controller = new();
        }

        [TestMethod]
        public void TestPostShutdown()
        {
            // Arrange
            var shutdownData = new DecoderPostData
            {
                ID = "AAAA000000",
                Address = "127.0.10.1",
                Action = "shutdown"
            };

            var infoData = new DecoderPostData
            {
                ID = "AAAA000000",
                Address = "127.0.10.1",
                Action = "info"
            };

            // Act
            var response = controller.Post(shutdownData);
            var info = controller.Post(infoData);

            // Assert
            StringAssert.StartsWith(response.Response, "OK");
            DecoderTestUtils.AssertState(info, "inactive");
        }
    }
}
