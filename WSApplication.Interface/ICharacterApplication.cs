using WSDomain.Entity;
using WSTransversal.Common;

namespace WSApplication.Interface
{
    public interface ICharacterApplication
    {
        Task<ResponseApiEntity> ResponseApi();
        Task<Response<List<SingleCharacter>>> GetCharactersAsync();
        Task<Response<SingleCharacter>> GetCharacterByIdAsync(int id);
        Task<Response<bool>> AddCharacterAsync(SingleCharacter character);
        Task<Response<bool>> DeleteCharacterAsync(int id);
    }
}
