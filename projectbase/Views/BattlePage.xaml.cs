using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace projectbase
{
    public partial class BattlePage : ContentPage
    {
        public BattlePage()
        {
            InitializeComponent();
            BindingContext = new Exercice2ViewModel();
        }
    }
}
