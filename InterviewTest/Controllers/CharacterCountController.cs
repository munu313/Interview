using InterviewTest.Abstract;
using InterviewTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterCountController : ControllerBase
    {
              
        static readonly ICountCharacterWord charword = new CountCharacterInWord();
        public CharacterCountController()
        {
            
        }

        [HttpGet(Name = "GetCharacterCount")]
        public async Task<NumberofCharacterResponse> Get([FromQuery] string input)
        {
           NumberofCharacterResponse chresponse= await charword.GetChacterCounts(input);
           return chresponse;
        }
    }
}