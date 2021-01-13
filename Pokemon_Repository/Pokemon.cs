using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    // private -> public | can't be declared private
    public enum PokemonType
    {
        Normal = 1, // changed index to 1
        Grass,
        Fire,
        Water,
        Electric,
        Ice,
        Bug,
        Ground,
        Rock,
        Fighting,
        Psychic,
        Ghost,
        Dark,
        Fairy,
        Dragon,
        None
    }

    // private -> public | can't be declared private
    public class Pokemon
    {
        public string PokemonSpeciesName { get; set; }  /* there was no ';' after 'get' */
        public string PokemonNickName { get; set; }
        public int Level { get; set; } // 'i' -> 'int' | Spelling error caused an issue in the type
        public PokemonType PokemonType { get; set; }
        public PokemonType SecondaryType; /* 'PokeonType?' -> 'PokemonType' | spelling error | also added ';' at end of line */
        public string MoveOne { get; set; }
        public string MoveTwo { get; set; } /* added 'string' | a type needed to be declared */
        public string MoveThree { get; set; }
        public string MoveFour { get; set; }

        public Pokemon(string speciesName, string NickName, int level, PokemonType pokemonType, PokemonType secondaryType, string moveOne, string moveTwo, string moveThree, string moveFour)
        {
            //TeamPosition = teamPosition;
            PokemonSpeciesName = speciesName;
            PokemonNickName = NickName; // 'nickName -> NickName | capitalization error
            Level = level;
            PokemonType = pokemonType;
            SecondaryType = secondaryType; // added ';'
            MoveOne = moveOne;
            MoveTwo = moveTwo;
            MoveThree = moveThree; // 'moveTwo' -> 'moveThree' | used wrong variable to set the property | also needed to be inside the curly brackets for the Pokemon constructor method
            MoveFour = moveFour; // needed to be inside the curly brackets for the Pokemon constructor method
        }
            
    } // missed a '}'
}
