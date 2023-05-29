using InterviewTest.Abstract;
using InterviewTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterCountController : ControllerBase
    {
      

        private readonly ILogger<CharacterCountController> _logger;
        static readonly ICountCharacterWord charword = new CountChacterInWord();
        public CharacterCountController(ILogger<CharacterCountController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCharacterCount")]
        public NumberofCharacterResponse Get([FromQuery] string input)
        {
           NumberofCharacterResponse chresponse= charword.GetChacterCounts(input);
           return chresponse;
        }
    }
}