using WSApplication.Interface;
using WSDomain.Entity;
using WSDomain.Interface;
using WSTransversal.Common;

namespace WSApplication.Main
{
    public class CharactersApplication : ICharacterApplication
    {
        private readonly ICharactersDomain _charactersDomain;

        public Task<Response<bool>> AddCharacterAsync(SingleCharacter character)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<SingleCharacter>> GetCharacterByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<SingleCharacter>>> GetCharactersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseApiEntity> ResponseApi()
        {
            throw new NotImplementedException();
        }
    }
}