using projectbase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectbase.ViewModels
{
    class PokemonViewModel : BaseViewModel
    {
        string username;
        public string Username { get => username; set => SetProperty(ref username, value); }
        string description;
        public string Description { get => description; set => SetProperty(ref description, value); }
        string birthDate;
        public string BirthDate { get => birthDate; set => SetProperty(ref birthDate, value); }
        string birthPlace;
        public string BirthPlace { get => birthPlace; set => SetProperty(ref birthPlace, value); }
        string nbViews;
        public string NbViews { get => nbViews; set => SetProperty(ref nbViews, value); }
        string nbShare;
        public string NbShare { get => nbShare; set => SetProperty(ref nbShare, value); }
        string imageLink;
        public string ImageLink { get => imageLink; set => SetProperty(ref imageLink, value); }
        string backgroundImageLink;
        public string BackgroundImageLink { get => backgroundImageLink; set => SetProperty(ref backgroundImageLink, value); }

        public PokemonViewModel(Pokemon user)
        {
            Username = user.Username;
            Description = user.Description;
            BirthDate = user.BirthDate;
            BirthPlace = user.BirthPlace;
            NbViews = user.NbViews;
            NbShare = user.NbShare;
            ImageLink = user.ImageLink;
            BackgroundImageLink = user.BackgroundImageLink;
        }
    }
}

