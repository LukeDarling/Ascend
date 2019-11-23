using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascend {
    class Box {
        public double x { get; set; }
        public double y { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }

        public Box() {
            x = 0;
            y = 0;
            x2 = 0;
            y2 = 0;
        }

        public Box(double x, double y) {
            this.x2 = x;
            this.y2 = y;
        }

        public bool Overlaps(Box box) {
            double xMinThis = Math.Min(x, x2);
            double xMaxThis = Math.Max(x, x2);
            double xMinThat = Math.Min(box.x, box.x2);
            double xMaxThat = Math.Max(box.x, box.x2);

            double yMinThis = Math.Min(y, y2);
            double yMaxThis = Math.Max(y, y2);
            double yMinThat = Math.Min(box.y, box.y2);
            double yMaxThat = Math.Max(box.y, box.y2);

            if (xMinThis < xMaxThat || xMaxThis > xMinThat) {
                if (yMinThis < yMaxThat || yMaxThis > yMinThat) {
                    return true;
                }
            }

            return false;
        }

        public bool Overlaps(Vector2 point) {
            double xMinThis = Math.Min(x, x2);
            double xMaxThis = Math.Max(x, x2);

            double yMinThis = Math.Min(y, y2);
            double yMaxThis = Math.Max(y, y2);

            if (xMinThis < point.x || xMaxThis > point.x) {
                if (yMinThis < point.y || yMaxThis > point.y) {
                    return true;
                }
            }

            return false;
        }

    }
}
