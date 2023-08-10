using WSApplication.Interface;
using WSDomain.Entity;
using WSDomain.Interface;
using WSTransversal.Common;

namespace WSApplication.Main
{
    public class CharactersApplication : ICharacterApplication
    {
        private readonly ICharactersDomain _charactersDomain;

        public CharactersApplication(ICharactersDomain charactersDomain)
        {
            _charactersDomain = charactersDomain;
        }
        public async Task<Response<bool>> AddCharacterAsync(SingleCharacter character)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _charactersDomain.AddCharacterAsync(character);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Creado con exito";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<bool>> DeleteCharacterAsync(int id)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _charactersDomain.DeleteCharacterAsync(id);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminacion exitosa";
                }
            }
            catch (Exception e)
            {

                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<SingleCharacter>> GetCharacterByIdAsync(int id)
        {
            var response = new Response<SingleCharacter>();
            try
            {
                response.Data = await _charactersDomain.GetCharacterByIdAsync(id);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception e)
            {

                response.Message = e.Message;
            }

            return response;
        }

        public async Task<Response<List<SingleCharacter>>> GetCharactersAsync()
        {
            var response = new Response<List<SingleCharacter>>();

            try
            {
                response.Data = await _charactersDomain.GetCharactersAsync();

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Lista de todos los personajes";
                }
            }
            catch (Exception e)
            {

                response.Message = e.Message;
            }

            return response;
        }

        public async Task<Response<ResponseApiEntity>> ResponseApi()
        {
            var response = new Response<ResponseApiEntity>();
            try
            {
                response.Data = await _charactersDomain.ResponseApi();
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Respuesta de la API de Rick And Morty";
                }
            }
            catch (Exception e)
            {

                response.Message = e.Message;
            }

            return response;
        }
    }
}