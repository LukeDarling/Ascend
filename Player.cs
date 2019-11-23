using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascend {
    class Player : Box {

        // Speed applied when the user walks
        public const double WalkingVelocity = 0.05;

        // Speed applied when the user jumps
        public const double JumpingVelocity = 10;

        // Amount of time between attacks
        public const double AttackTimeoutMS = 250;

        // Friction applied per game tick
        public const double Friction = 0.02;

        // Gravity applied per game tick
        public const double Gravity = 0.05;

        // Weight of the player
        public const double Weight = 100;

        public bool IsCheatingEnabled { get; set; }

        public enum State { Standing, Walking, Jumping, Falling, Attacking, Attacked, Dead }

        public enum Direction { Left, Right, Center }

        public string Username { get; set; }

        public State PlayerState { get; set; }

        public Direction PlayerDirection { get; set; }

        public double xVelocity { get; set; }
        public double yVelocity { get; set; }

        public bool IsOnGround { get; set; }

        public void HandleGameTick() {

            // Update player velocities
            if(xVelocity > 0) {
                xVelocity = xVelocity - Friction;
            }
            if(xVelocity < 0) {
                xVelocity = xVelocity + Friction;
            }
            if(!IsOnGround) {
                yVelocity = yVelocity - Gravity;
            }

            // Update player state
            if (PlayerState != State.Attacking) {

                // Standing still
                if (xVelocity == 0 && yVelocity == 0) {
                    PlayerState = State.Standing;
                    PlayerDirection = Direction.Center;
                }
                // Waliking left
                else if (xVelocity < 0 && yVelocity == 0) {
                    PlayerState = State.Walking;
                    PlayerDirection = Direction.Left;
                }
                // Waliking right
                else if (xVelocity > 0 && yVelocity == 0) {
                    PlayerState = State.Walking;
                    PlayerDirection = Direction.Right;
                }
                // Jumping straight up
                else if (xVelocity == 0 && yVelocity > 0) {
                    PlayerState = State.Jumping;
                    PlayerDirection = Direction.Center;
                }
                // Jumping left
                else if (xVelocity < 0 && yVelocity > 0) {
                    PlayerState = State.Jumping;
                    PlayerDirection = Direction.Left;
                }
                // Jumping right
                else if (xVelocity > 0 && yVelocity > 0) {
                    PlayerState = State.Jumping;
                    PlayerDirection = Direction.Right;
                }
                // Falling straight down
                else if(xVelocity == 0 && yVelocity < 0) {
                    PlayerState = State.Falling;
                    PlayerDirection = Direction.Center;
                }
                // Falling left
                else if (xVelocity < 0 && yVelocity < 0) {
                    PlayerState = State.Falling;
                    PlayerDirection = Direction.Left;
                }
                // Falling right
                else if (xVelocity > 0 && yVelocity < 0) {
                    PlayerState = State.Falling;
                    PlayerDirection = Direction.Right;
                }
            }


        }

        public void HandleInput(char input) {

            // Handle right movement
            if(input == 'd') {
                xVelocity = Math.Max(WalkingVelocity, xVelocity);
            }

            // Handle left movement
            if(input == 'a') {
                xVelocity = Math.Min(-WalkingVelocity, xVelocity);
            }

            // Handle jumping
            if (input == 'w') {
                if (IsOnGround || IsCheatingEnabled) {
                    yVelocity = Math.Max(JumpingVelocity, yVelocity);
                }
            }

            // Handle attacking
            if(input == ' ') {
                SendAttack();
            }
        }

        public void SendAttack() {
            // TODO
        }

    }
}
