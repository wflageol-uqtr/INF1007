using DecoderWebServer.Server.Model;

namespace DecoderWebServer.Tests
{
    [TestClass]
    public class DecoderTests
    {
        Decoder decoder;

        [TestInitialize]
        public void Setup()
        {
            decoder = new(1);
        }

        [TestMethod]
        public void TestDefaultInfo()
        {
            // Arrange & Act
            var info = decoder.Info;

            // Assert
            DecoderTestUtils.AssertState(info, "active");
        }

        [TestMethod]
        public void TestShutdown()
        {
            // Arrange & Act
            decoder.Shutdown();
            var info = decoder.Info;

            // Assert
            DecoderTestUtils.AssertState(info, "inactive");
        }
    }
}