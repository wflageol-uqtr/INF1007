namespace DecoderWebServer.Server.Model
{
    public interface DecoderResponse
    {
        string Response { get; }
    }

    public class OKResponse : DecoderResponse
    {
        public string Response => "OK";
    }

    public class InfoResponse : OKResponse
    {
        public string State { get; set; } = "";
        public string LastReset { get; set; } = "";
        public string LastReinit { get; set; } = "";
    }

    public class ErrorResponse : DecoderResponse
    {
        public string Response => "Error";
        public string Message { get; set; } = "";
    }
}
