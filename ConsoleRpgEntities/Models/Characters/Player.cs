using ConsoleRpgEntities.Migrations;
using ConsoleRpgEntities.Models.Abilities.PlayerAbilities;
using ConsoleRpgEntities.Models.Attributes;

namespace ConsoleRpgEntities.Models.Characters
{
    public class Player : ITargetable, IPlayer
    {
        public int Experience { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public virtual IEnumerable<Ability> Abilities { get; set; }
        public virtual Equipments? Equipments { get; set; }
        public void Attack(ITargetable target)
        {
            // Player-specific attack logic
            if(Equipments != null && Equipments.Weapon != null)
            {
                Console.WriteLine($"{Name} attacks {target.Name} with {Equipments.Weapon.Name} dealing {Equipments.Weapon.Attack} damage!");
            }
            else {
                Console.WriteLine($"{Name} attacks {target.Name} with fists dealing 3 damage!");
            }
            
        }

        public void UseAbility(IAbility ability, ITargetable target)
        {
            if (Abilities.Contains(ability))
            {
                ability.Activate(this, target);
            }
            else
            {
                Console.WriteLine($"{Name} does not have the ability {ability.Name}!");
            }
        }
    }
}
