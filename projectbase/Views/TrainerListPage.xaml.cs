using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace projectbase
{
    public partial class TrainerListPage: ContentPage
    {
        public TrainerListPage()
        {
            InitializeComponent();
            BindingContext = new TrainerListViewModel();
        }
    }
}
