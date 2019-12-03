using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascend {
    public class Box {
        public double x {
            get {
                return x;
            }
            set {
                x = value;
                xMin = Math.Min(x, x2);
                xMax = Math.Max(x, x2);
            }
        }
        public double y {
            get {
                return y;
            }
            set {
                y = value;
                yMin = Math.Min(y, y2);
                yMax = Math.Max(y, y2);
            }
        }
        public double x2 {
            get {
                return x2;
            }
            set {
                x2 = value;
                xMin = Math.Min(x, x2);
                xMax = Math.Max(x, x2);
            }
        }
        public double y2 {
            get {
                return y2;
            }
            set {
                y2 = value;
                yMin = Math.Min(y, y2);
                yMax = Math.Max(y, y2);
            }
        }
        public double xMin { get; set; }
        public double yMin { get; set; }
        public double xMax { get; set; }
        public double yMax { get; set; }

        public Box() {
            x = 0;
            y = 0;
            x2 = 0;
            y2 = 0;
        }

        public Box(double x, double y) {
            x2 = x;
            y2 = y;
        }

        public bool Overlaps(Box box) {
            if (xMin < box.xMax || xMax > box.xMin) {
                if (yMin < box.yMax || yMax > box.yMin) {
                    return true;
                }
            }
            return false;
        }

        public bool Overlaps(Vector2 point) {
            if (xMin < point.x || xMax > point.x) {
                if (yMin < point.y || yMax > point.y) {
                    return true;
                }
            }
            return false;
        }

    }
}
