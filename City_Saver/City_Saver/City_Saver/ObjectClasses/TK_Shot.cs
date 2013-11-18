using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace City_Saver.ObjectClasses
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class TK_Shot : ObjectClasses.Weapon
    {
        private int cost = 2;//the MP cost to use the attack
        public TK_Shot()
        {
            AttackDamage = 10;//the damage amount of the attack
            
        }

        //returns the cost to use the attack
        public int getCost()
        {
            return cost;
        }
        
    }
}
