using rpg_gameplay.logic.enums;
using rpg_gameplay.assets.story.components;
using rpg_gameplay.model.characters;
using rpg_gameplay.model;
using rpg_gameplay.view;


namespace rpg_gameplay.assets.story;

public class Act1: Act
{
    
        public override void Play()
        {
                Introduction();
                InitCharacter();
        }

        private static void Introduction()
        {
                List<string> lines = [
                
                        "The market is bustling with voices and the sound of carts.\n As you make your way through the crowded stalls, you spot a stranger who seems familiar with the area.\n You decide to ask him for directions.",
                        "The stranger sizes you up for a moment, his sharp eyes scanning your face and build. A faint smile curves his lips.",
                        "Hm… You don't seem to be one of us. You must be from far away, right?\nWhich tribe do you belong to?"
                ];

                ConsoleMenu.Display(lines);
        }
        
        private static void InitCharacter()
        {
                List<TribeType> tribeChoices = [TribeType.Elf, TribeType.Human, TribeType.Dwarf ];
                List<RoleType> rolesChoices = [
                        RoleType.Arcanist,
                        RoleType.Clerc,
                        RoleType.Rogue,
                        RoleType.Warrior,
                ];
                List<string> lines = [
                        "Oh, I see...\n",
                        "You must be a skilled adventurer to have made it this far.\n",
                ];
                
                var tribeChoice = ConsoleMenu.Select("Which tribe are you from?", tribeChoices.ToArray());
                var roleChoice = ConsoleMenu.Select("What is your role?", rolesChoices.ToArray());
                
                var selectedTribe = tribeChoices[tribeChoice];
                var selectedRole = rolesChoices[roleChoice];
                
                ConsoleMenu.Display(lines);
                
                var name = ConsoleMenu.Ask("Tell me, what is your name?\n");
                
                var player = CharacterFactory.Create(name, selectedTribe, selectedRole);
                GameState.Instance.World.Player = player;
                
                Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(player));
        }

}