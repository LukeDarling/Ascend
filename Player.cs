using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascend
{
    class Player
    {
        public enum State { Standing, WalkingR, WalkingL, Jumping, JumpingR, JumpingL, Falling, Attacking }

        public string Username { get; set; }

        public State PlayerState { get; set; }

        public float XLoc { get; set; }
        public float YLoc { get; set; }
        public float XVelocity { get; set; }
        public float YVelocity { get; set; }

        public bool IsOnGround { get; set; }

        public void HandleInput(char input)
        {
            switch (PlayerState)
            {
                case State.Standing:
                    if (input == 'a')
                    {
                        // Handle Momentum Change
                        PlayerState = State.WalkingL;
                    }
                    else if (input == 'd')
                    {
                        // Handle Momentum Change
                        PlayerState = State.WalkingR;
                    }
                    else if (input == ' ')
                    {
                        // Handle Momentum Change
                        PlayerState = State.Jumping;
                    }
                    break;
                case State.Jumping:
                    if (input == ' ' /* and they haven't exceeded the max height of a jump */)
                    {
                        // Handle Momentum Change
                    }
                    if (IsOnGround) { PlayerState = State.Standing; }
                    // if (Should be falling) { PlayerState = State.Falling; }
                    break;
                case State.JumpingL:
                    if (input == 'd')
                    {
                        // Handle Momentum Change
                        PlayerState = State.JumpingR;
                    }
                    else if (input == ' ' /* and they haven't exceeded the max height of a jump */)
                    {
                        // Handle Momentum Change
                        PlayerState = State.Jumping;
                    }
                    else
                    {
                        // Handle Momentum Change
                        PlayerState = State.Falling;
                    }
                    break;
                case State.JumpingR:
                    if (input == 'a')
                    {
                        // Handle Momentum Change
                        PlayerState = State.JumpingL;
                    }
                    else if (input == ' ' /* and they haven't exceeded the max height of a jump */)
                    {
                        // Handle Momentum Change
                        PlayerState = State.Jumping;
                    }
                    else
                    {
                        // Handle Momentum Change
                        PlayerState = State.Falling;
                    }
                    break;
                case State.Falling:
                    // Reduce all momentum other than negative vertical
                    // if (IsOnGround) { PlayerState = State.Standing; }
                    break;
                case State.WalkingL:
                    // Handle WalkingL cases
                    break;
                case State.WalkingR:
                    // Handle WalkingR cases
                    break;
            }
        }
    }
}
