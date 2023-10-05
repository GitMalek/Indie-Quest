using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Metanoia_Tutorial.Program;

namespace Metanoia_Tutorial
{
    internal partial class Program
    {
        static Menu CharacterCreation = new Menu()
        {
            Run = () =>
        {
            Console.WriteLine("You are sleeping peacefully on a wagon to Symposia, the infinite frontier of magic and hardship. Who are you?");
            Console.WriteLine();

            List<Option> options = new();

            options.Add(new Option()
            {
                DisplayText = gameState.playerCharacter.Name == null ? "Enter your name" : gameState.playerCharacter.Name + " - Change your name",
                Run = () =>
                {
                    Console.Clear();
                    Console.WriteLine("Your name is: ");
                    gameState.playerCharacter.Name = Console.ReadLine();
                }
            }
            );

            options.Add(new Option()
            {
                DisplayText = gameState.playerCharacter.Origin == null ? "Choose your origin" : gameState.playerCharacter.Origin + " - Change your origin",
                Run = () =>
                {
                    gameState.CurrentMenus.Add(OriginSelection);
                }
            }
            );

            options.Add(new Option()
            {
                DisplayText = gameState.playerCharacter.Heritage == null ? "Choose your heritage" : gameState.playerCharacter.Heritage + " - Change your heritage",
                Run = () =>
                {
                    gameState.CurrentMenus.Add(HeritageSelection);
                }
            }
            );

            options.Add(new Option()
            {
                DisplayText = gameState.playerCharacter.ObtainedSkills.Count() < 3 ? "Choose your starting skills" : $"{gameState.playerCharacter.ObtainedSkills[0]}, {gameState.playerCharacter.ObtainedSkills[1]}, {gameState.playerCharacter.ObtainedSkills[2]} - Change your starting skills",
                Run = () =>
                {
                    gameState.playerCharacter.ObtainedSkills.Clear();
                    gameState.CurrentMenus.Add(StartingSkillsCategoryMenu);
                }
            }
            );

            if (gameState.playerCharacter.Name != null && gameState.playerCharacter.Origin != null && gameState.playerCharacter.Heritage != null && gameState.playerCharacter.ObtainedSkills != null)
            {
                options.Add(new Option()
                {
                    DisplayText = "Awaken",
                    Run = () =>
                    {
                        JournalEntry originEntry = new();

                        switch (gameState.playerCharacter.Origin)
                        {
                            case "Symposia":
                                originEntry = Symposia;
                                break;
                            case "Akros - Umbra":
                            case "Akros - Astra":
                            case "Akros - Unaligned":
                                originEntry = Akros;
                                break;
                            case "Frijia":
                                originEntry = Frijia;
                                break;
                            case "Eudaina":
                                originEntry = Eudaina;
                                break;
                            case "New Shinari - Upper Steps":
                            case "New Shinari - Lower Steps":
                                originEntry = NewShinari; 
                                break;
                            case "Miasmire":
                                originEntry = Miasmire;
                                break;
                            case "Lands Between And Beyond":
                                originEntry = LandsBetweenAndBeyond;
                                break;
                        }

                        originEntry.EntryFamiliarity += 10;

                        JournalEntry heritageEntry = new();

                        switch (gameState.playerCharacter.Heritage)
                        {
                            case "Human":
                                heritageEntry = Human;
                                break;
                            case "Elven":
                                heritageEntry = Elves;
                                break;
                        }

                        heritageEntry.EntryFamiliarity += 10;
                    }
                }
                );
            }

            OptionHandler(options);
        }
        };

        static Menu OriginSelection = new Menu()
        {
            Run = () =>
            {
                Console.WriteLine("Many flock to Symposia from all across the world. Where are you from?");
                Console.WriteLine();

                List<Option> options = new();

                options.Add(back);

                options.Add(new Option()
                {
                    DisplayText = "Symposia",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(CreateOriginConfirmationMenu(0));
                    }
                }
                );

                options.Add(new Option()
                {
                    DisplayText = "Akros",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(CreateOriginConfirmationMenu(1));
                    }
                }
                );

                options.Add(new Option()
                {
                    DisplayText = "Frijia",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(CreateOriginConfirmationMenu(2));
                    }
                }
                );

                options.Add(new Option()
                {
                    DisplayText = "Eudaina",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(CreateOriginConfirmationMenu(3));
                    }
                }
                );

                options.Add(new Option()
                {
                    DisplayText = "New Shinari",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(CreateOriginConfirmationMenu(4));
                    }
                }
                );

                options.Add(new Option()
                {
                    DisplayText = "Miasmire",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(CreateOriginConfirmationMenu(5));
                    }
                }
                );

                options.Add(new Option()
                {
                    DisplayText = "Lands Between And Beyond",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(CreateOriginConfirmationMenu(6));
                    }
                }
                );

                OptionHandler(options);
            }
        };

        // ORIGIN CONFIRMATION SCREENS
        static Menu CreateOriginConfirmationMenu(int id)
        {
            return new Menu()
            {
                Run = () =>
                {
                    JournalEntry chosenOrigin = new JournalEntry();

                    switch (id)
                    {
                        case 0:
                            chosenOrigin = Symposia;
                            break;
                        case 1:
                            chosenOrigin = Akros;
                            break;
                        case 2:
                            chosenOrigin = Frijia;
                            break;
                        case 3:
                            chosenOrigin = Eudaina;
                            break;
                        case 4:
                            chosenOrigin = NewShinari;
                            break;
                        case 5:
                            chosenOrigin = Miasmire;
                            break;
                        case 6:
                            chosenOrigin = LandsBetweenAndBeyond;
                            break;
                    }

                    Console.WriteLine(chosenOrigin.EntryDescription);
                    Console.WriteLine();
                    Console.WriteLine(chosenOrigin.CreationEntryContextText);

                    if (id != 1 && id !=4)
                    {
                        Console.WriteLine($"Are you sure you want to pick {chosenOrigin.EntryName}?");
                    }


                    List<Option> options = new();

                    options.Add(back);

                    if (id != 1 && id != 4)
                    {
                        options.Add(new Option()
                        {
                            DisplayText = "Yes",
                            Run = () =>
                            {
                                gameState.playerCharacter.Origin = chosenOrigin.EntryName;
                                ReturnToMenu(CharacterCreation);
                            }
                        }
                        );
                    }

                    else if (id == 1)
                    {
                        options.Add(new Option()
                        {
                            DisplayText = "Astra",
                            Run = () =>
                            {
                                gameState.playerCharacter.Origin = "Akros - Astra";
                                ReturnToMenu(CharacterCreation);
                            }
                        }
                        );

                        options.Add(new Option()
                        {
                            DisplayText = "Umbra",
                            Run = () =>
                            {
                                gameState.playerCharacter.Origin = "Akros - Umbra";
                                ReturnToMenu(CharacterCreation);
                            }
                        }
                        );

                        options.Add(new Option()
                        {
                            DisplayText = "Unaligned",
                            Run = () =>
                            {
                                gameState.playerCharacter.Origin = "Akros - Unaligned";
                                ReturnToMenu(CharacterCreation);
                            }
                        }
                        );
                    }

                    else if (id == 4)
                    {
                        options.Add(new Option()
                        {
                            DisplayText = "Upper Steps",
                            Run = () =>
                            {
                                gameState.playerCharacter.Origin = "New Shinari - Upper Steps";
                                ReturnToMenu(CharacterCreation);
                            }
                        }
                        );

                        options.Add(new Option()
                        {
                            DisplayText = "Lower Steps",
                            Run = () =>
                            {
                                gameState.playerCharacter.Origin = "New Shianri - Lower Steps";
                                ReturnToMenu(CharacterCreation);
                            }
                        }
                        );
                    }

                    OptionHandler(options);
                }
            };
        }
        

        //HERITAGE  SELECTION
        static Menu HeritageSelection = new Menu()
        {
            Run = () =>
            {
                Console.WriteLine("People of all sorts find themselves in Symposia. Many are human, some have other heritages - most 'demi-humans' are in fact the descendants of humans that were magically altered by magic or a god.");
                Console.WriteLine();

                List<Option> options = new();

                options.Add(back);

                options.Add(new Option()
                {
                    DisplayText = "Human",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(CreateHeritageConfirmationMenu("Human"));
                    }
                }
                );

                options.Add(new Option()
                {
                    DisplayText = "Elven",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(CreateHeritageConfirmationMenu("Elven"));
                    }
                }
                );

                OptionHandler(options);
            }
        };


        //HERITAGE CONFIRMATION
        static Menu CreateHeritageConfirmationMenu(string heritage)
        {
            return new Menu()
            {
                Run = () =>
                {
                    JournalEntry chosenHeritage = new JournalEntry();

                    switch (heritage)
                    {
                        case "Human":
                            chosenHeritage = Human;
                            break;
                        case "Elven":
                            chosenHeritage = Elves;
                            break;
                    }

                    Console.WriteLine(chosenHeritage.EntryDescription);
                    Console.WriteLine();

                    Console.WriteLine(chosenHeritage.CreationEntryContextText);
                    Console.WriteLine();

                    Console.WriteLine($"Are you sure you want your heritage to be {heritage}?");

                    List<Option> options = new List<Option>();

                    options.Add(back);

                    options.Add(new Option()
                    {
                        DisplayText = "Yes",
                        Run = () =>
                        {
                            gameState.playerCharacter.Heritage = heritage;
                            ReturnToMenu(CharacterCreation);
                        }
                    }
                    );

                    OptionHandler(options);
                }
            };
        }
       
        //SKILLS SELECTION
        static Menu StartingSkillsCategoryMenu = new Menu()
        {
            Run = () =>
            {
                Console.WriteLine("Though you're certain to explore many avenues when you reach Symposia, you've already had a few experiences in your life to make you a cut above the rest in some areas. What are you skilled in?");
                Console.WriteLine();

                List<Option> options = new();

                options.Add(new Option()
                {
                    DisplayText = "Combat",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(StartingSkillsCombatMenu);
                    }
                }
                );

                options.Add(new Option()
                {
                    DisplayText = "Gathering",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(StartingSkillsGatheringMenu);
                    }
                }
                );

                options.Add(new Option()
                {
                    DisplayText = "Production",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(StartingSkillsProductionMenu);
                    }
                }
                );

                options.Add(new Option()
                {
                    DisplayText = "Expression",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(StartingSkillsExpressionMenu);
                    }
                }
                );

                options.Add(new Option()
                {
                    DisplayText = "Discovery",
                    Run = () =>
                    {
                        gameState.CurrentMenus.Add(StartingSkillsDiscoveryMenu);
                    }
                }
                );

                OptionHandler(options);
            }
        };

        static Menu StartingSkillsCombatMenu = new Menu()
        {
            Run = () =>
            {
                Console.WriteLine("Although combat isn't the be all end all solution to all problems- the ability to settle disputes by force and hunt things that fight back comes in handy. A character can't win combats until they have at least one combat skill.");
                Console.WriteLine("Some enemies have weaknesses or resistances to certain combat styles. You can mix and match multiple skills from multiple styles.");

                Console.WriteLine();

                List<Option> options = new();

                options.Add(back);

                foreach (string skill in gameState.Skills.CombatSkills)
                {
                    if (!gameState.playerCharacter.ObtainedSkills.Contains(skill))
                    {
                        options.Add(new Option()
                        {
                            DisplayText = skill,
                            Run = () =>
                            {
                                gameState.playerCharacter.ObtainedSkills.Add(skill);
                                
                                if (gameState.playerCharacter.ObtainedSkills.Count == 3)
                                {
                                    ReturnToMenu(CharacterCreation);
                                }
                            }
                        }
                        );
                    }
                }

                OptionHandler(options);
            }
        };

        static Menu StartingSkillsGatheringMenu = new Menu()
        {
            Run = () =>
            {
                Console.WriteLine("Those skilled in gathering are great at making the most out of nature's bounty. Be it acquiring gifts, ingredients for food, or metals and materials for weapons and art- gatherers know where to look, and what to look for.");

                Console.WriteLine();

                List<Option> options = new();

                options.Add(back);

                foreach (string skill in gameState.Skills.GatheringSkills)
                {
                    if (!gameState.playerCharacter.ObtainedSkills.Contains(skill))
                    {
                        options.Add(new Option()
                        {
                            DisplayText = skill,
                            Run = () =>
                            {
                                gameState.playerCharacter.ObtainedSkills.Add(skill);

                                if (gameState.playerCharacter.ObtainedSkills.Count == 3)
                                {
                                    ReturnToMenu(CharacterCreation);
                                }
                            }
                        }
                        );
                    }
                }

                OptionHandler(options);
            }
        };


        static Menu StartingSkillsProductionMenu = new Menu()
        {
            Run = () =>
            {
                Console.WriteLine("Production covers the crafts and trades. From smithing weapons and armor, to constructing useful furniture, or innovating with entirely new creations.");

                Console.WriteLine();

                List<Option> options = new();

                options.Add(back);

                foreach (string skill in gameState.Skills.ProductionSkills)
                {
                    if (!gameState.playerCharacter.ObtainedSkills.Contains(skill))
                    {
                        options.Add(new Option()
                        {
                            DisplayText = skill,
                            Run = () =>
                            {
                                gameState.playerCharacter.ObtainedSkills.Add(skill);

                                if (gameState.playerCharacter.ObtainedSkills.Count == 3)
                                {
                                    ReturnToMenu(CharacterCreation);
                                }
                            }
                        }
                        );
                    }
                }

                OptionHandler(options);
            }
        };

        static Menu StartingSkillsExpressionMenu = new Menu()
        {
            Run = () =>
            {
                Console.WriteLine("Expression encompasses one's ability to create art of all kinds. Whether it's in the manner of a performance, a masterfully drawn painting, or a meal cooked with love- Expression combines familiarity and inspiration to create gifts from the heart.");

                Console.WriteLine();

                List<Option> options = new();

                options.Add(back);

                foreach (string skill in gameState.Skills.ExpressionSkills)
                {
                    if (!gameState.playerCharacter.ObtainedSkills.Contains(skill))
                    {
                        options.Add(new Option()
                        {
                            DisplayText = skill,
                            Run = () =>
                            {
                                gameState.playerCharacter.ObtainedSkills.Add(skill);

                                if (gameState.playerCharacter.ObtainedSkills.Count == 3)
                                {
                                    ReturnToMenu(CharacterCreation);
                                }
                            }
                        }
                        );
                    }
                }

                OptionHandler(options);
            }
        };

        static Menu StartingSkillsUtilityMenu = new Menu()
        {
            Run = () =>
            {
                Console.WriteLine("Utility encompasses a wide range of skills that come in handy in all manner of situations. Knowing how to handle people better, control over the arcane to change the weather or lift objects, or one's ability to call on the gods for help. These talents come in handy quite often.");

                Console.WriteLine();

                List<Option> options = new();

                options.Add(back);

                foreach (string skill in gameState.Skills.UtilitySkills)
                {
                    if (!gameState.playerCharacter.ObtainedSkills.Contains(skill))
                    {
                        options.Add(new Option()
                        {
                            DisplayText = skill,
                            Run = () =>
                            {
                                if (skill != "(Prayer) - Believer of...")
                                {
                                    gameState.playerCharacter.ObtainedSkills.Add(skill);

                                    if (gameState.playerCharacter.ObtainedSkills.Count == 3)
                                    {
                                        ReturnToMenu(CharacterCreation);
                                    }
                                }
                                
                                else
                                {
                                    gameState.CurrentMenus.Add(PrayerSkillSelection);
                                }
                            }
                        }
                        );
                    }
                }

                OptionHandler(options);
            }
        };

        static Menu StartingSkillsDiscoveryMenu = new Menu()
        {
            Run = () =>
            {
                Console.WriteLine("Discovery centers around one's ability to see more of the world. It encompasses one's ability to travel quickly, and one's ability to look more closely at their surroundings. Be it investigating the material world, or seeing far into a world beyond to spot things invisible to the naked eye.");

                Console.WriteLine();

                List<Option> options = new();

                options.Add(back);

                foreach (string skill in gameState.Skills.DiscoverySkills)
                {
                    if (!gameState.playerCharacter.ObtainedSkills.Contains(skill))
                    {
                        options.Add(new Option()
                        {
                            DisplayText = skill,
                            Run = () =>
                            {
                                gameState.playerCharacter.ObtainedSkills.Add(skill);

                                if (gameState.playerCharacter.ObtainedSkills.Count == 3)
                                {
                                    ReturnToMenu(CharacterCreation);
                                }
                            }
                        }
                        );
                    }
                }
                OptionHandler(options);
            }
        };

        static Menu PrayerSkillSelection = new Menu()
        {
            Run = () =>
            {
                Console.WriteLine("The gods might be distant at times, but they respond to those that reach out to them. Adherence to prayer or a god's philosophy allows you to get along with those that share similar beliefs- and eventually, your prayers might be answered in more meaningful ways if you devote yourself enough.");

                Console.WriteLine();

                List<Option> options = new();

                options.Add(back);

                foreach (string skill in gameState.Skills.PrayerGods)
                {
                    if (!gameState.playerCharacter.ObtainedSkills.Contains("(Prayer) - Believer of " + skill))
                    {
                        options.Add(new Option()
                        {
                            DisplayText = skill,
                            Run = () =>
                            {
                                gameState.CurrentMenus.Add(CreatePrayerConfirmationMenu(skill));
                            }
                        }
                        );
                    }
                }
                OptionHandler(options);
            }
        };

        static Menu CreatePrayerConfirmationMenu(string skill)
        {
            return new Menu()
            {
                Run = () =>
                {
                    JournalEntry god = new JournalEntry();

                    switch (skill)
                    {
                        case "Oberon":
                            god = Oberon;
                            break;
                        case "Alytheos":
                            god = Alytheos;
                            break;
                        case "Lexandri":
                            god = Lexandri;
                            break;
                        case "Eradius":
                            god = Eradius;
                            break;
                        case "Asmodai":
                            god = Asmodai;
                            break;
                        case "Thalessia":
                            god = Thalessia;
                            break;
                        case "Lysia":
                            god = Lysia;
                            break;
                        case "The Mortal Spirit":
                            god = TheMortalSpirit;
                            break;
                    }

                    Console.WriteLine(god.EntryDescription);
                    Console.WriteLine();

                    Console.WriteLine(god.CreationEntryContextText);
                    Console.WriteLine();

                    Console.WriteLine($"Are you sure you wish to be a believer of {god.EntryName}?");

                    List<Option> options = new List<Option>();

                    options.Add(back);

                    options.Add(new Option()
                    {
                        DisplayText = "Yes",
                        Run = () =>
                        {
                            gameState.playerCharacter.ObtainedSkills.Add("(Prayer) - Believer of " + skill);
                            if (gameState.playerCharacter.ObtainedSkills.Count == 3)
                            {
                                ReturnToMenu(CharacterCreation);
                            }
                        }
                    }
                    );
                }
            };
        }
    }
}
