using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace City_Saver.ObjectClasses
{
    class Player: ObjectClasses.People, Animation.walkAnimation
    {
        GamePadState currentControl;//the controller state of the player
        //The Telekinesis abilities of the player
        TK_Shield barrier = new TK_Shield();
        TK_Shot shot = new TK_Shot();
        public Player()
        {
        }

        /*
         * Maybe add a LoadContent method here?
         */

        public void Update(GameTime gameTime)
        {
            //moves the player right-forward
            if (currentControl.ThumbSticks.Right.X == 1.0f)
            {
            }
                //moves the player left-backwards
            else if (currentControl.ThumbSticks.Left.X == 1.0f)
            {
            }

            /*
             * The vertical movement of the player
             * HERE
             */

            /*
             * The diagonal movement of the player
             * HERE
             */

            /*
             * The telekinesis ability activation by the player
             * LT = TK Shot
             * RT = TK Shield
             */
            //Activate the TK Shot
            if (currentControl.Triggers.Left == 1.0f)
            {
            }

            //Activates the TK Shield
            if (currentControl.Triggers.Right == 1.0f)
            {
            }

        }

        void Animation.walkAnimation.playWalkAnimation()
        {
            
        }
    }
}
