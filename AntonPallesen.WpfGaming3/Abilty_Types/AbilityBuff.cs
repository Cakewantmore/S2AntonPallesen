using System;
using System.Collections.Generic;
using System.Text;

namespace AntonPallesen.WpfGaming3.Abilty_Types
{
    class AbilityBuff : Ability
    {
        public AbilityBuff(string name, string desc) : base(name, desc)
        {

        }
        public override int useAbility(int Power, EnemyClass target)
        {
            return base.useAbility(Power, target);
        }
    }
}
