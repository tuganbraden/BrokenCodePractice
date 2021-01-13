using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    // private -> public | can't be declared private
    public class PokemonRepository
    {
        List<Pokemon> _pokemonTeam = new List<Pokemon>();
    

        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam(Pokemon pokemon) // needed a return type
        {
            if (_pokemonTeam.Count < 6)
            {
                _pokemonTeam.Add(pokemon); // 'new Pokemon' -> 'pokemon' | needs to use the Pokemon passed from the parameter, not create a new one
            }
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam; // needed to return a List<Pokemon>
        }
        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }
        //update pokemon
        public void UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
            pokemon.PokemonNickName = updates.PokemonNickName;
            pokemon.Level = updates.Level; // 'pokemon.level' -> 'pokemon.Level' | capitalization error caused a nonexistent property to try to be called | also added ';' at end
            pokemon.PokemonType = updates.PokemonType;
            pokemon.SecondaryType = updates.SecondaryType;
            pokemon.MoveOne = updates.MoveOne; // added ';'
            pokemon.MoveTwo = updates.MoveTwo; // 'pokemon.MoveTwo' -> 'pokemon.MoveTwo' | same as line 37
            pokemon.MoveThree = updates.MoveThree;
            pokemon.MoveFour = updates.MoveFour; // added ';'
        }

        public void UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        {
            Pokemon update = GetPokemonByNickname(nickName);
            update.PokemonSpeciesName = newPokemon.PokemonSpeciesName;
            update.PokemonNickName = newPokemon.PokemonNickName;
            update.Level = newPokemon.Level;
            update.PokemonType = newPokemon.PokemonType;
            update.SecondaryType = newPokemon.SecondaryType;
            update.MoveOne = newPokemon.MoveOne;
            update.MoveTwo = newPokemon.MoveTwo;
            update.MoveThree = newPokemon.MoveThree;
            update.MoveFour = newPokemon.MoveFour; 
        }

        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            _pokemonTeam.Remove(pokemon); // List uses Remove method instead of Dequeue
        }

        public Pokemon GetPokemonByNickname (string nickname) 
        {
            foreach (Pokemon p in _pokemonTeam) // 'pokemonList' -> '_pokemonTeam' | changed to match repo name
            {
                if (nickname == p.PokemonNickName)
                {
                    return p;                       /* Moved foreach loop to a separate method */
                }
            }
            return null;
        }
        
    } // moved from line 13 to here | none of the methods were in the class
}
