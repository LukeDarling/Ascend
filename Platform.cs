using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascend {
    class Platform : Box {

        public double yVelocity;

        public Platform() {
            yVelocity = -0.02;
        }

        public void ScrollDown() {
            y -= yVelocity;
        }

        public void HandleGameTick() {
            ScrollDown();
        }
    }
}
