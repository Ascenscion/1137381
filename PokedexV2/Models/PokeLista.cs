using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexV2.Models
{
    public class PokeLista
    {
        [JsonProperty("count")]
        public long cantidad { get; set; }
        [JsonProperty("next")]
        public string siguiente { get; set; }
        [JsonProperty("previous")]
        public object anterior { get; set; }
        [JsonProperty("results")]
        public List<Pokemon> listaPokemon { get; set; }
    }
}
