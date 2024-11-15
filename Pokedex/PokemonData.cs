using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class PokemonData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SpriteData Sprite { get; set; }
        public List<TypeData> Types { get; set; }
    }
}
