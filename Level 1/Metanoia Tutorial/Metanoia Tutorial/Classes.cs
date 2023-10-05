using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metanoia_Tutorial
{
    internal partial class Program
    {
        public static GameState gameState = new GameState();

        public class Menu
        {
            public Action Run;
        }

        public class Option
        {
            public string DisplayText;
            public Action Run;
        }

        public class Location
        {
            public string Name;
            public string Description;
            public List<Location> Neighbors = new();
        }

        public class GameState
        {
            public PlayerCharacter playerCharacter = new();

            public Location CurrentLocation = new();
            public List<Menu> CurrentMenus = new();
            public Menu LastMenu => CurrentMenus[^1];
            public Skills Skills = new();
        }

        public class PlayerCharacter
        {
            public string Name;
            public string Origin;
            public string Heritage;

            //SKILLS
            public List<string> ObtainedSkills = new(); 
        }

        public class JournalEntry
        {
            public string EntryName;
            public string EntryDescription;
            public string CreationEntryContextText;
            public int EntryFamiliarity;
        }

        public class Skills
        {
            public List<string> CombatSkills = new List<string>() { "(Martial) - Strike", "(Ranged) - Shoot", "(Spellcasting) - Mana Bolt", "(Slaying) - Exploit Weakness" };
            public List<string> GatheringSkills = new List<string>() { "(Nature) - Mining", "(Nature) - Woodcutting", "(Nature) - Foraging", "(Nature) - Hunting", "(Nature) - Fishing", "(Nature) - Farming" };
            public List<string> ProductionSkills = new List<string>() { "(Artifice) - Smithing", "Artifice - Crafting", "(Artifice) - Invention", "(Arcana) - Enchantment", "(Artifice) - Construction", "(Arcana) - Alchemy" };
            public List<string> ExpressionSkills = new List<string>() { "(Artistry) - Art", "(Artistry) - Writing", "(Artistry) - Performance", "(Artistry) - Cooking", "(Artistry) - Mixology" };
            public List<string> UtilitySkills = new List<string>() { "(Arcana) - Arcana", "(Prayer) - Believer of...", "(Speech) - Eloquence", "(Thievery) - Thievery", "(Insight) - Insight" };
            public List<string> DiscoverySkills = new List<string>() { "(Agility) - Agility", "(Archeology) - Archeology", "(Investigation) - Investigation", "(Far Sight) - Far Sight", "(Navigation) - Navigation" };
            public List<string> PrayerGods = new List<string>() { "Oberon", "Alytheos", "Lexandri", "Eradius", "Asmodai", "Thalessia", "Lysia", "The Mortal Spirit" };
        }
    }
}
