using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApi.Models
{
    public class Character
    {
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("apellidos")]
        public string Apellidos { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("sexo")]
        public string Sexo { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }
    }
}
