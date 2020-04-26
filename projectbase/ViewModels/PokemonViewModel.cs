using PokeApiNet;
using projectbase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectbase.ViewModels
{
    class PokemonViewModel : BaseViewModel
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
        string type1;
        public string Type1 { get => type1; set => SetProperty(ref type1, value); }
        string type2;
        public string Type2 { get => type2; set => SetProperty(ref type2, value); }

        public PokemonViewModel(PokemonModel pokemonModel)
        {
            Id = pokemonModel.Id;
            Name = pokemonModel.Name;
            Sprites = pokemonModel.Sprites;
            Weight = pokemonModel.Weight;
            Order = pokemonModel.Order;
            Height = pokemonModel.Height;
            BaseExperience = pokemonModel.BaseExperience;
            Stats = pokemonModel.Stats;
            Types = pokemonModel.Types;
            Type1 = typeToImageLink(pokemonModel.Type1);
            Type2 = typeToImageLink(pokemonModel.Type2);
        }

        public string typeToImageLink(string type)
        {
            switch (type)
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
                default:
                    return "";
            }

        }
    }
}

