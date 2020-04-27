using PokeApiNet;
using projectbase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectbase.ViewModels
{
    class TrainerViewModel : BaseViewModel
    {
        int id;
        public int Id { get => id; set => SetProperty(ref id, value); }
        string name;
        public string Name { get => name; set => SetProperty(ref name, value); }
        string sprite;
        public string Sprite { get => sprite; set => SetProperty(ref sprite, value); }
        string pokemon1;
        public string Pokemon1 { get => pokemon1; set => SetProperty(ref pokemon1, value); }
        string pokemon2;
        public string Pokemon2 { get => pokemon2; set => SetProperty(ref pokemon2, value); }
        string pokemon3;
        public string Pokemon3 { get => pokemon3; set => SetProperty(ref pokemon3, value); }
        string pokemon4;
        public string Pokemon4 { get => pokemon4; set => SetProperty(ref pokemon4, value); }
        string pokemon5;
        public string Pokemon5 { get => pokemon5; set => SetProperty(ref pokemon5, value); }
        string pokemon6;
        public string Pokemon6 { get => pokemon6; set => SetProperty(ref pokemon6, value); }

        string pokemonSprite1;
        public string PokemonSprite1 { get => pokemonSprite1; set => SetProperty(ref pokemonSprite1, value); }
        string pokemonSprite2;
        public string PokemonSprite2 { get => pokemonSprite2; set => SetProperty(ref pokemonSprite2, value); }
        string pokemonSprite3;
        public string PokemonSprite3 { get => pokemonSprite3; set => SetProperty(ref pokemonSprite3, value); }
        string pokemonSprite4;
        public string PokemonSprite4 { get => pokemonSprite4; set => SetProperty(ref pokemonSprite4, value); }
        string pokemonSprite5;
        public string PokemonSprite5 { get => pokemonSprite5; set => SetProperty(ref pokemonSprite5, value); }
        string pokemonSprite6;
        public string PokemonSprite6 { get => pokemonSprite6; set => SetProperty(ref pokemonSprite6, value); }

        public TrainerViewModel(Trainer trainer)
        {
            Id = trainer.ID;
            Name = trainer.Name;
            Sprite = trainer.Sprite;
            pokemon1 = trainer.Pokemon1;
            pokemon2 = trainer.Pokemon2;
            pokemon3 = trainer.Pokemon3;
            pokemon4 = trainer.Pokemon4;
            pokemon5 = trainer.Pokemon5;
            pokemon6 = trainer.Pokemon6;

            fetchData();
        }

        public async void fetchData()
        {
            Pokemon getRecupered;
            List<PokemonModel> team = new List<PokemonModel>();

            List<string> sprites = new List<string>();
            sprites.Add(Pokemon1);
            sprites.Add(Pokemon2);
            sprites.Add(Pokemon3);
            sprites.Add(Pokemon4);
            sprites.Add(Pokemon5);
            sprites.Add(Pokemon6);

            foreach(string sprite in sprites)
            {
                getRecupered = await App.client.GetResourceAsync<Pokemon>(sprite);
                PokemonModel pokemonDetailled = new PokemonModel()
                {
                    Id = getRecupered.Id,
                    Name = getRecupered.Name.Substring(0, 1).ToUpper() + getRecupered.Name.Substring(1, getRecupered.Name.Length - 1),
                    Height = getRecupered.Height,
                    Weight = getRecupered.Weight,
                    BaseExperience = getRecupered.BaseExperience,
                    Order = getRecupered.Order,
                    Sprites = getRecupered.Sprites.FrontDefault,
                    Stats = getRecupered.Stats,
                    Types = getRecupered.Types,
                    Type1 = getRecupered.Types.Count > 1 ? getRecupered.Types[1].Type.Name : getRecupered.Types[0].Type.Name,
                    Type2 = getRecupered.Types.Count > 1 ? getRecupered.Types[0].Type.Name : ""
                };
                team.Add(pokemonDetailled);
            }
            pokemonSprite1 = team[0].Sprites;
            pokemonSprite2 = team[1].Sprites;
            pokemonSprite3 = team[2].Sprites;
            pokemonSprite4 = team[3].Sprites;
            pokemonSprite5 = team[4].Sprites;
            pokemonSprite6 = team[5].Sprites;
        }
    }
}
