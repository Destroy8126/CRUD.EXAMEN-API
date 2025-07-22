using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CrudApi.Models;
using Newtonsoft.Json;

namespace CrudApi.Controllers
{
    public class CharactersController
    {
        private readonly HttpClient client;

        public CharactersController()
        {
            client = new HttpClient();
        }

        // GET: Obtener todos los personajes
        public async Task<Characters> GetAllCharacters()
        {
            try
            {
                Characters characters = new Characters();
                HttpResponseMessage response = await client.GetAsync("http://localhost:3000/api/usuarios/");

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                characters = JsonConvert.DeserializeObject<Characters>(responseJson);

                return characters;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // POST: Crear un nuevo personaje
        public async Task<bool> CreateCharacter(Character character)
        {
            try
            {
                string json = JsonConvert.SerializeObject(character);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("http://localhost:3000/api/usuarios/", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> DeleteCharacter(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync($"http://localhost:3000/api/usuarios/{id}");

                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> UpdateCharacter(int id, Character character)
        {
            try
            {
                string json = JsonConvert.SerializeObject(character);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync($"http://localhost:3000/api/usuarios/{id}", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
