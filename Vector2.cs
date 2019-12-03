using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascend {
    public class Vector2 {

        public double x { get; set; }
        public double y { get; set; }

        public Vector2() {
            x = 0;
            y = 0;
        }

        public Vector2(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public bool Overlaps(Vector2 point) {
            if (point.x == x) {
                if (point.y == y) {
                    return true;
                }
            }
            return false;
        }

        public bool Overlaps(Box box) {
            return box.Overlaps(this);
        }

    }
}
