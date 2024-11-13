using ConsoleRpgEntities.Models.Attributes;

namespace ConsoleRpgEntities.Models.Characters.Monsters
{
    public class Goblin : Monster
    {
        public int Sneakiness { get; set; }

        public override void Attack(ITargetable target)
        {
            // Goblin-specific attack logic
            if (target is Player player)
            {
                if (player.Equipments != null && player.Equipments.Armor != null)
                {
                    var damageDealt = 10 - player.Equipments.Armor.Defense;
                    if (damageDealt < 0) { damageDealt = 0; }
                    Console.WriteLine($"{Name} sneaks up and attacks {player.Name} dealing {damageDealt}!");
                    player.Health -= damageDealt;
                }
            }
            else
            {
                Console.WriteLine($"{Name} sneaks up and attacks {target.Name} dealing 10 damage!");
            }
        }
    }
}
