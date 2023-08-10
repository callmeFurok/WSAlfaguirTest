using WSDomain.Entity;
using WSDomain.Interface;
using WSInfraestructure.Interface;

namespace WSDomain.Core
{
    public class CharactersDomain : ICharactersDomain
    {
        private readonly ICharacterRepository _charactersRepository;

        public CharactersDomain(ICharacterRepository characterRepository)
        {
            _charactersRepository = characterRepository;

        }

        public async Task<bool> AddCharacterAsync(SingleCharacter character)
        {
            return await _charactersRepository.AddCharacterAsync(character);
        }

        public async Task<bool> DeleteCharacterAsync(int id)
        {
            return await _charactersRepository.DeleteCharacterAsync(id);
        }

        public async Task<SingleCharacter> GetCharacterByIdAsync(int id)
        {
            return await _charactersRepository.GetCharacterByIdAsync(id);
        }

        public async Task<List<SingleCharacter>> GetCharactersAsync()
        {
            return await _charactersRepository.GetCharactersAsync();
        }

        public async Task<ResponseApiEntity> ResponseApi()
        {
            return await _charactersRepository.ResponseApi();
        }
    }
}
