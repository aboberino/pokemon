﻿using PokeApiNet;
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
        }
    }
}

