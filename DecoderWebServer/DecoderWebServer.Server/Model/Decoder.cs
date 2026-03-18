namespace DecoderWebServer.Server.Model
{
    public class Decoder
    {
        public byte[] Address { get; }
        public DecoderState State { get; }
        public DateTime LastRestart { get; }
        public DateTime LastReinit { get; }

        public Decoder(byte address)
        {
            Address = [127, 0, 10, address];
            State = DecoderState.Active;
            LastRestart = new DateTime(2026, 1, 1);
            LastReinit = new DateTime(2026, 1, 1);
        }
    }

    public enum DecoderState
    {
        Active,
        Inactive
    }
}
