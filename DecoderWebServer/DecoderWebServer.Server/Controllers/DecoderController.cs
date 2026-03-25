using DecoderWebServer.Server.Model;
using Microsoft.AspNetCore.Mvc;

namespace DecoderWebServer.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecoderController : ControllerBase
    {
        private List<Student> students = new();

        private Student GetStudent(string id)
        {
            foreach(var student in students)
            {
                if (string.Equals(student.StudentID, id))
                    return student;
            }

            throw new ArgumentException("L'étudiant n'a pas été trouvé.");
        }

        private byte ConvertStringDecoderAddress(string address)
        {
            var elements = address.Split('.');
            var element = elements.Last();
            return byte.Parse(element);
        }

        [HttpPost]
        public IDecoderResponse Post([FromBody] DecoderPostData data)
        {
            try
            {
                var student = GetStudent(data.ID);
                var decoder = student.GetDecoderByAddress(
                    ConvertStringDecoderAddress(data.Address));

                switch (data.Action)
                {
                    case "info":
                        return decoder.Info;
                    case "reset":
                        decoder.Reset();
                        return new OKResponse();
                    case "reinit":
                        decoder.Reinit();
                        return new OKResponse();
                    case "shutdown":
                        decoder.Reset();
                        return new OKResponse();
                    default:
                        return new ErrorResponse
                        {
                            Message = "Action non reconnue."
                        };
                }
            } catch (Exception ex)
            {
                return new ErrorResponse { Message = ex.Message };
            }
        }
    }

    public class DecoderPostData
    {
        public string ID { get; set; }
        public string Address { get; set; }
        public string Action { get; set; }
    }
}
