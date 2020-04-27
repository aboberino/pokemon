using projectbase.Models;
using projectbase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectbase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainerPage : ContentPage
    {
        public TrainerPage(Trainer trainer)
        {
            InitializeComponent();
            BindingContext = new TrainerViewModel(trainer);
        }
    }
}