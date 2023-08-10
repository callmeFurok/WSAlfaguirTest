using WSDomain.Entity;

namespace WSDomain.Interface
{
    public interface ICharactersDomain
    {
        Task<ResponseApiEntity> ResponseApi();
        Task<List<SingleCharacter>> GetCharactersAsync();
        Task<SingleCharacter> GetCharacterByIdAsync(int id);
        Task<bool> AddCharacterAsync(SingleCharacter character);
        Task<bool> DeleteCharacterAsync(int id);
    }
}
