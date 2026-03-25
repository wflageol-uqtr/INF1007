namespace DecoderWebServer.Server.Model
{
    public class Decoder
    {
        public byte[] Address { get; }
        public DecoderState State { get; private set; }
        public DateTime LastRestart { get; private set; }
        public DateTime LastReinit { get; private set; }

        public Decoder(byte address)
        {
            Address = [127, 0, 10, address];
            State = DecoderState.Active;
            LastRestart = new DateTime(2026, 1, 1);
            LastReinit = new DateTime(2026, 1, 1);
        }

        public IDecoderResponse Info => new InfoResponse
        {
            LastReinit = LastReinit.ToString(),
            LastReset = LastRestart.ToString(),
            State = State.ToString()
        };

        public void Reset()
        {
            LastRestart = DateTime.Now;
        }

        public void Reinit()
        {
            LastReinit = DateTime.Now;
        }

        public void Shutdown()
        {
            State = DecoderState.Inactive;
        }
    }

    public enum DecoderState
    {
        Active,
        Inactive
    }
}
