using projectbase.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectbase
{
    public partial class App : Application
    {
        public static ObservableCollection<Pokemon> Pokemons;
        public App()
        {
            InitializeComponent();
            Pokemons = new ObservableCollection<Pokemon>();
            Pokemons.Add(new Pokemon()
            {
                Username = "Perceval",
                Description = "Chef de clan des semi-croustillants",
                BirthDate = "01/01/1491",
                BirthPlace = "Caerdydd, Pays de Galles",
                NbViews = "42",
                NbShare = "0",
                ImageLink = "https://i.pinimg.com/originals/92/96/fe/9296fe17d842595a2a91f1f042b132b7.jpg",
                BackgroundImageLink = "https://www.erenumerique.fr/wp-content/uploads/2019/04/kaamelott.jpg"
            });
            Pokemons.Add(new Pokemon()
            {
                Username = "Arthur",
                Description = "Roi de Bretagne",
                BirthDate = "02/02/1491",
                BirthPlace = "Tintagel",
                NbViews = "99",
                NbShare = "0",
                ImageLink = "https://i.pinimg.com/originals/fd/e7/56/fde75655f598b9300a7511bd7d7bda5d.jpg",
                BackgroundImageLink = "https://www.erenumerique.fr/wp-content/uploads/2019/04/kaamelott.jpg"
            });
            Pokemons.Add(new Pokemon()
            {
                Username = "Lancelot",
                Description = "Chevalier errant",
                BirthDate = "03/03/1491",
                BirthPlace = "Trèbe, Armorique",
                NbViews = "36",
                NbShare = "0",
                ImageLink = "https://i.skyrock.net/4092/16894092/pics/463774427.jpg",
                BackgroundImageLink = "https://www.erenumerique.fr/wp-content/uploads/2019/04/kaamelott.jpg"
            });
            Pokemons.Add(new Pokemon()
            {
                Username = "Guenièvre",
                Description = "Reine de Bretagne",
                BirthDate = "04/04/1491",
                BirthPlace = "Carmélide",
                NbViews = "150",
                NbShare = "0",
                ImageLink = "https://vignette.wikia.nocookie.net/kaamelott-officiel/images/1/14/Gueni%C3%A8vre.jpg/revision/latest/top-crop/width/360/height/450?cb=20131014040706&path-prefix=fr",
                BackgroundImageLink = "https://www.erenumerique.fr/wp-content/uploads/2019/04/kaamelott.jpg"
            });
            MainPage = new NavigationPage(new MyTabbedPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
