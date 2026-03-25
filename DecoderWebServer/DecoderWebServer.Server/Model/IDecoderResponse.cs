namespace DecoderWebServer.Server.Model
{
    public interface IDecoderResponse
    {
        string Response { get; }
    }

    public class OKResponse : IDecoderResponse
    {
        public string Response => "OK";
    }

    public class InfoResponse : OKResponse
    {
        public string State { get; set; } = "";
        public string LastReset { get; set; } = "";
        public string LastReinit { get; set; } = "";
    }

    public class ErrorResponse : IDecoderResponse
    {
        public string Response => "Error";
        public string Message { get; set; } = "";
    }
}
