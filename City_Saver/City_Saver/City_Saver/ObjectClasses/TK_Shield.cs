using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace City_Saver.ObjectClasses
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class TK_Shield :ObjectClasses.Weapon
    {
        private int cost = 1;
        public TK_Shield()
        {
            AttackDamage = 0;
        }

        public int MPcost
        {
            get
            {
                return cost;
            }
        }
    }
}
