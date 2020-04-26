using projectbase.Models;
using System;
using System.Collections.ObjectModel;

namespace projectbase
{
    public class TrainerListViewModel : BaseViewModel
    {
        ObservableCollection<Trainer> trainers;
        public ObservableCollection<Trainer> Trainers { get => trainers; set => SetProperty(ref trainers, value); }

        public TrainerListViewModel()
        {
            setData();
        }

        async void setData()
        {
            Trainer t1 = new Trainer()
            {
                Name = "Sacha"
            };
            Trainer t2 = new Trainer()
            {
                Name = "Red"
            };
            await App.Database.DeleteAllTrainerAsync();
            await App.Database.SaveTrainerAsync(t1);
            await App.Database.SaveTrainerAsync(t2);
            Trainers = new ObservableCollection<Trainer>(await App.Database.GetTrainerAsync());
        }
    }
}
