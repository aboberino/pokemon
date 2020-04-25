using projectbase.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace projectbase
{
    public class PokemonListViewModel : BaseViewModel
    {
        ObservableCollection<Pokemon> pokemons;
        public ObservableCollection<Pokemon> Pokemons { get => pokemons; set => SetProperty(ref pokemons, value); }
        Pokemon pokemonSelected;
        public Pokemon PokemonSelected
        {
            get => PokemonSelected;
            set
            {
                SetProperty(ref pokemonSelected, value);
                if (value != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Application.Current.MainPage.Navigation.PushAsync(new PokemonPage(value));
                        PokemonSelected = null;
                    });
                }
            }
        }

        public PokemonListViewModel()
        {
            Pokemons = new ObservableCollection<Pokemon>(App.Pokemons);
            //PokemonSelected = null;
        }

        public void Refresh()
        {
            Pokemons = new ObservableCollection<Pokemon>(App.Pokemons);

        }
    }
}
