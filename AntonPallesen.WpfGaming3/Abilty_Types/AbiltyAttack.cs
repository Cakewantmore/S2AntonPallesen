using System;
using System.Collections.Generic;
using System.Text;

namespace AntonPallesen.WpfGaming3.Abilty_Types
{
    class AbilityAttack : Ability
    {
        public AbilityAttack(string name, string desc) : base(name, desc)
        {

        }

        public override int useAbility(int Power, EnemyClass target)
        {
            return base.useAbility(Power, target);
        }
    }
}
