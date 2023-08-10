using WSDomain.Entity;

namespace WSInfraestructure.Interface
{
    public interface ICharacterRepository
    {
        Task<ResponseApiEntity> ResponseApi();
        Task<List<SingleCharacter>> GetCharactersAsync();
        Task<SingleCharacter> GetCharacterByIdAsync(int id);
        Task<bool> AddCharacterAsync(SingleCharacter character);
        Task<bool> DeleteCharacterAsync(int id);
        Task<bool> SaveAsync();
    }
}
