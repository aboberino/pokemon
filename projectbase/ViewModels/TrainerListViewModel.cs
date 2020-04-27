using projectbase.Models;
using projectbase.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Diagnostics;

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

        public ICommand OnClickedAddTrainerButton { get => new Command(AddTrainerButtonClicked); }

        async void AddTrainerButtonClicked()
        {
            string name = await Application.Current.MainPage.DisplayPromptAsync("Add Trainer", "Enter a Name");
            Trainer newTrainer = new Trainer
            {
                Name = name,
                Sprite = "https://myuu.xyz/images/trainers/Psychic-F-A.png",
                Pokemon1 = "charizard",
                Pokemon2 = "articuno",
                Pokemon3 = "mewtwo",
                Pokemon4 = "dragonair",
                Pokemon5 = "dragonite",
                Pokemon6 = "pidgeot"
            };
            await App.Database.SaveTrainerAsync(newTrainer);
            Trainers = new ObservableCollection<Trainer>(await App.Database.GetTrainerAsync());
        }

        async void setData()
        {
            Trainers = new ObservableCollection<Trainer>(await App.Database.GetTrainerAsync());
        }
    }
}
