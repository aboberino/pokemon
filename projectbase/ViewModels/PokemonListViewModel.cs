﻿using projectbase.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using PokeApiNet;
using System.Collections.Generic;

namespace projectbase
{
    public class PokemonListViewModel : BaseViewModel
    {
        ObservableCollection<PokemonModel> pokemons;
        public ObservableCollection<PokemonModel> Pokemons { get => pokemons; set => SetProperty(ref pokemons, value); }
        PokemonModel pokemonSelected;
        public PokemonModel PokemonSelected
        {
            get => PokemonSelected;
            set
            {
                SetProperty(ref pokemonSelected, value);
                if (value != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {

                        Pokemon pokemonRecuperedMdr = await App.client.GetResourceAsync<Pokemon>(value.Name);

                        PokemonModel pokemonDetailled = new PokemonModel()
                        {
                            Id = pokemonRecuperedMdr.Id,
                            Name = pokemonRecuperedMdr.Name.Substring(0, 1).ToUpper()+ pokemonRecuperedMdr.Name.Substring(1, pokemonRecuperedMdr.Name.Length-1),
                            Height = pokemonRecuperedMdr.Height,
                            Weight = pokemonRecuperedMdr.Weight,
                            BaseExperience = pokemonRecuperedMdr.BaseExperience,
                            Order = pokemonRecuperedMdr.Order,
                            Sprites = pokemonRecuperedMdr.Sprites.FrontDefault,
                            Stats = pokemonRecuperedMdr.Stats,
                            Types = pokemonRecuperedMdr.Types,
                            Type1 = pokemonRecuperedMdr.Types.Count > 1 ? pokemonRecuperedMdr.Types[1].Type.Name : pokemonRecuperedMdr.Types[0].Type.Name,
                            Type2 = pokemonRecuperedMdr.Types.Count > 1 ? pokemonRecuperedMdr.Types[0].Type.Name : ""
                        };
                        await Application.Current.MainPage.Navigation.PushAsync(new PokemonPage(pokemonDetailled));
                        PokemonSelected = null;
                    });
                }
            }
        }




        public PokemonListViewModel()
        {
            App.client = new PokeApiClient();
            Pokemons = new ObservableCollection<PokemonModel>();

            fetchData();

        }

        public async void fetchData()
        {
            Pokedex pokedex = await App.client.GetResourceAsync<Pokedex>(2);
            List<PokemonEntry> listOfPokemon = pokedex.PokemonEntries;

            foreach (PokemonEntry poke in listOfPokemon)
            {
                Pokemons.Add(new PokemonModel()
                {
                    Id = poke.EntryNumber,
                    Name = poke.PokemonSpecies.Name.Substring(0, 1).ToUpper() + poke.PokemonSpecies.Name.Substring(1, poke.PokemonSpecies.Name.Length - 1)
                });
            }
        }
            
    }
}
