namespace projectbase.Models
{
    public class Pokemon : BaseViewModel
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

        public Pokemon()
        {
            Username = "";
            Description = "";
            BirthDate = "";
            BirthPlace = "";
            NbViews = "";
            NbShare = "0";
            ImageLink = "";
            BackgroundImageLink = "https://www.erenumerique.fr/wp-content/uploads/2019/04/kaamelott.jpg";
        }
    }
}
