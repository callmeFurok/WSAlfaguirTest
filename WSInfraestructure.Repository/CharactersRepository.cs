using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WSDomain.Entity;
using WSInfraestructure.Data;
using WSInfraestructure.Interface;

namespace WSInfraestructure.Repository
{
    public class CharactersRepository : ICharacterRepository
    {

        private readonly InMemoryDbContext _inMemoryDb;

        public CharactersRepository(InMemoryDbContext inMemoryDb)
        {
            _inMemoryDb = inMemoryDb;
        }
        public async Task<bool> AddCharacterAsync(SingleCharacter character)
        {
            await _inMemoryDb.SingleCharacter.AddAsync(character);
            var response = await SaveAsync();
            return response;

        }

        public async Task<bool> DeleteCharacterAsync(int id)
        {
            var characterToDelete = await GetCharacterByIdAsync(id);
            _inMemoryDb.SingleCharacter.Remove(characterToDelete);
            return await SaveAsync();
        }

        public async Task<SingleCharacter> GetCharacterByIdAsync(int id)
        {
            var character = await _inMemoryDb.SingleCharacter.FirstOrDefaultAsync(c => c.Id == id);
            return character;
        }

        public async Task<List<SingleCharacter>> GetCharactersAsync()
        {
            var characters = await _inMemoryDb.SingleCharacter.ToListAsync();
            return characters;

        }


        //  use rick and morty api an return all characters
        public async Task<ResponseApiEntity> ResponseApi()
        {
            var apiUrl = "https://rickandmortyapi.com/api/character";
            var client = new HttpClient();
            var response = await client.GetAsync(apiUrl);
            var result = await response.Content.ReadAsStringAsync();
            var resultObject = JsonConvert.DeserializeObject<ResponseApiEntity>(result);
            return resultObject;
        }


        public async Task<bool> SaveAsync()
        {
            return await _inMemoryDb.SaveChangesAsync() > 0;
        }
    }
}