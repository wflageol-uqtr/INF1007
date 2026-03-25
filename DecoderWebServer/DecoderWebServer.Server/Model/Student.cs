namespace DecoderWebServer.Server.Model
{
    public class Student
    {
        private Decoder[] decoders = new Decoder[12];

        public string StudentID { get; }

        public Student(string studentID)
        {
            for (int i = 1; i <= 12; i++)
                decoders[i - 1] = new Decoder((byte)i);

            StudentID = studentID;
        }

        public Decoder GetDecoderByAddress(byte address)
        {
            return decoders[address - 1];
        }
    }
}
