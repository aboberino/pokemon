using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace projectbase
{
    public partial class PokemonListPage : ContentPage
    {
        public PokemonListPage()
        {
            InitializeComponent();
            BindingContext = new PokemonListViewModel();
        }
    }
}
