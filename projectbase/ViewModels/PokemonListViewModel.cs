using projectbase.Models;
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
        PokeApiClient client;
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

                        Pokemon pokemonRecuperedMdr = await client.GetResourceAsync<Pokemon>(value.Name);

                        PokemonModel pokemonDetailled = new PokemonModel()
                        {
                            Id = pokemonRecuperedMdr.Id,
                            Name = pokemonRecuperedMdr.Name,
                            Height = pokemonRecuperedMdr.Height,
                            Weight = pokemonRecuperedMdr.Weight,
                            BaseExperience = pokemonRecuperedMdr.BaseExperience,
                            Order = pokemonRecuperedMdr.Order,
                            Sprites = pokemonRecuperedMdr.Sprites.FrontDefault,
                            Stats = pokemonRecuperedMdr.Stats,
                            Types = pokemonRecuperedMdr.Types,
                            Type1 = pokemonRecuperedMdr.Types[0].Type.Name,
                            Type2 = pokemonRecuperedMdr.Types.Count > 1 ? pokemonRecuperedMdr.Types[1].Type.Name : ""
                        };

                        await Application.Current.MainPage.Navigation.PushAsync(new PokemonPage(pokemonDetailled));
                        PokemonSelected = null;
                    });
                }
            }
        }




        public PokemonListViewModel()
        {
            client = new PokeApiClient();
            Pokemons = new ObservableCollection<PokemonModel>();

            fetchData();

        }

        public async void fetchData()
        {
            Pokedex pokedex = await client.GetResourceAsync<Pokedex>(1);
            List<PokemonEntry> listOfPokemon = pokedex.PokemonEntries;

            foreach (PokemonEntry poke in listOfPokemon)
            {
                Pokemons.Add(new PokemonModel()
                {
                    Id = poke.EntryNumber,
                    Name = poke.PokemonSpecies.Name
                });
            }
        }
            
    }
}
