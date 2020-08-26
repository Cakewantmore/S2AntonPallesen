using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AntonPallesen.WpfGaming3
{
    public class AbilityRepository
    {
        private List<Ability> abilities = new List<Ability>();
        public AbilityRepository()
        {
            abilities.Add(new Ability("GoodAbilty", AbilityType.Debuff)) ;
        }
    }
}
