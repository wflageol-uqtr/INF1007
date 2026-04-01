using DecoderWebServer.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoderWebServer.Tests
{
    public static class DecoderTestUtils
    {
        public static void AssertState(IDecoderResponse response, string expected)
        {
            if (response is InfoResponse infoResponse)
                StringAssert.StartsWith(infoResponse.State, expected, StringComparison.InvariantCultureIgnoreCase);
            else
                Assert.Fail("Mauvais type de réponse.");
        }
    }
}
