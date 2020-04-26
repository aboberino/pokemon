using System;
using System.Windows.Input;
using projectbase.Interfaces;
using Xamarin.Forms;

namespace projectbase
{
    public class BattleViewModel : BaseViewModel
    {
        string toastText;
        public string ToastText
        {
            get { return toastText; }
            set { SetProperty(ref toastText, value); }
        }

        public ICommand ToastCommand => new Command(Toast);

        void Toast()
        {
            DependencyService.Get<IToastAlert>()?.DisplayAlert("Pas encore implémenté mdr");
        }
        public BattleViewModel()
        {

        }
    }
}
