using projectbase.Models;
using projectbase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectbase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonPage : ContentPage
    {
        public PokemonPage(PokemonModel pokemon)
        {
            InitializeComponent();
            BindingContext = new PokemonViewModel(pokemon);
        }
    }
}