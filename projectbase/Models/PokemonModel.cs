using PokeApiNet;
using System.Collections.Generic;

namespace projectbase.Models
{
    public class PokemonModel : BaseViewModel
    {

        int id;
        public int Id { get => id; set => SetProperty(ref id, value); }
        string name;
        public string Name { get => name; set => SetProperty(ref name, value); }
        string sprites;
        public string Sprites { get => sprites; set => SetProperty(ref sprites, value); }
        int weight;
        public int Weight { get => weight; set => SetProperty(ref weight, value); }
        int order;
        public int Order { get => order; set => SetProperty(ref order, value); }
        int height;
        public int Height { get => height; set => SetProperty(ref height, value); }
        int baseExperience;
        public int BaseExperience { get => baseExperience; set => SetProperty(ref baseExperience, value); }
        List<PokemonStat> stats;
        public List<PokemonStat> Stats { get => stats; set => SetProperty(ref stats, value); }
        List<PokemonType> types;
        public List<PokemonType> Types { get => types; set => SetProperty(ref types, value); }


        public PokemonModel() { }

        public string getType()
        {
            switch (Types[0].Type.Name)
            {
                case "normal":
                    return "https://www.pokebip.com/pages/icones/types/3G/normal.png";
                case "fighting":
                    return "https://www.pokebip.com/pages/icones/types/3G/combat.png";
                case "flying":
                    return "https://www.pokebip.com/pages/icones/types/3G/vol.png";
                case "poison":
                    return "https://www.pokebip.com/pages/icones/types/3G/poison.png";
                case "ground":
                    return "https://www.pokebip.com/pages/icones/types/3G/sol.png";
                case "rock":
                    return "https://www.pokebip.com/pages/icones/types/3G/roche.png";
                case "bug":
                    return "https://www.pokebip.com/pages/icones/types/3G/insecte.png";
                case "steel":
                    return "https://www.pokebip.com/pages/icones/types/3G/acier.png";
                case "fire":
                    return "https://www.pokebip.com/pages/icones/types/3G/feu.png";
                case "water":
                    return "https://www.pokebip.com/pages/icones/types/3G/eau.png";
                case "grass":
                    return "https://www.pokebip.com/pages/icones/types/3G/plante.png";
                case "electric":
                    return "https://www.pokebip.com/pages/icones/types/3G/electrik.png";
                case "psychic":
                    return "https://www.pokebip.com/pages/icones/types/3G/psy.png";
                case "ice":
                    return "https://www.pokebip.com/pages/icones/types/3G/glace.png";
                case "dragon":
                    return "https://www.pokebip.com/pages/icones/types/3G/dragon.png";
                case "dark":
                    return "https://www.pokebip.com/pages/icones/types/3G/tenebres.png";
                case "fairy":
                    return "";
                case "shadow":
                    return "";
                case "ghost":
                    return "";

                default:
                    return "https://www.pokebip.com/pages/icones/types/3G/normal.png";
            }

        }
    }
}
