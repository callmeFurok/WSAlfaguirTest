using Microsoft.AspNetCore.Mvc;
using WSApplication.Interface;
using WSDomain.Entity;

namespace WSServices.API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]

    public class CharactersController : ControllerBase
    {
        private readonly ICharacterApplication _charactersApplication;

        public CharactersController(ICharacterApplication charactersApplication)
        {
            _charactersApplication = charactersApplication;
        }

        [HttpGet]
        [Route("GetCharacters")]
        public async Task<IActionResult> GetCharacters()
        {
            return Ok(await _charactersApplication.GetCharactersAsync());
        }

        [HttpGet]
        [Route("GetCharacterById/{id}")]
        public async Task<IActionResult> GetCharacterById(int id)
        {
            return Ok(await _charactersApplication.GetCharacterByIdAsync(id));
        }

        [HttpPost]
        [Route("AddCharacter")]
        public async Task<IActionResult> AddCharacter([FromBody] SingleCharacter character)
        {
            return Ok(await _charactersApplication.AddCharacterAsync(character));
        }

        [HttpDelete]
        [Route("DeleteCharacter/{id}")]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
            return Ok(await _charactersApplication.DeleteCharacterAsync(id));
        }

        [HttpGet]
        [Route("ResponseApi")]
        public async Task<IActionResult> ResponseApi()
        {
            return Ok(await _charactersApplication.ResponseApi());
        }
    }
}
