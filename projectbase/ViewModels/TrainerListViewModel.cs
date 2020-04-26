using projectbase.Models;
using projectbase.Views;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace projectbase
{
    public class TrainerListViewModel : BaseViewModel
    {
        ObservableCollection<Trainer> trainers;
        public ObservableCollection<Trainer> Trainers { get => trainers; set => SetProperty(ref trainers, value); }
        Trainer trainerSelected;
        public Trainer TrainerSelected
        {
            get => TrainerSelected;
            set
            {
                SetProperty(ref trainerSelected, value);
                if (value != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Application.Current.MainPage.Navigation.PushAsync(new TrainerPage(value));
                        TrainerSelected = null;
                    });
                }
            }
        }


        public TrainerListViewModel()
        {
            setData();
        }

        async void setData()
        {
            Trainer t1 = new Trainer()
            {
                Name = "Rancher",
                Sprite = "https://myuu.xyz/images/trainers/Rancher.png",
                Pokemon1 = "charizard",
                Pokemon2 = "pikachu",
                Pokemon3 = "ivysaur",
                Pokemon4 = "ditto",
                Pokemon5 = "bulbasaur",
                Pokemon6 = "pidgeot"

            };
            Trainer t2 = new Trainer()
            {
                Name = "Dancer",
                Sprite = "https://myuu.xyz/images/trainers/Dancer.png",
                Pokemon1 = "pidgeotto",
                Pokemon2 = "pikachu",
                Pokemon3 = "ivysaur",
                Pokemon4 = "ditto",
                Pokemon5 = "bulbasaur",
                Pokemon6 = "pidgeot"
            };
            Trainer t3 = new Trainer()
            {
                Name = "Swimmer-M-B",
                Sprite = "https://myuu.xyz/images/trainers/Swimmer-M-B.png",
                Pokemon1 = "pidgeotto",
                Pokemon2 = "pikachu",
                Pokemon3 = "ivysaur",
                Pokemon4 = "ditto",
                Pokemon5 = "bulbasaur",
                Pokemon6 = "pidgeot"
            };
            await App.Database.DeleteAllTrainerAsync();
            await App.Database.SaveTrainerAsync(t1);
            await App.Database.SaveTrainerAsync(t2);
            await App.Database.SaveTrainerAsync(t3);
            Trainers = new ObservableCollection<Trainer>(await App.Database.GetTrainerAsync());
        }
    }
}
