using System;
using System.Collections.Generic;
using System.Text;

namespace OopShapesProject {
     public class SquareComp {

        private Quad quad;

        public int GetPerimeter() {
            return quad.GetPerimeter();
        }
        public int GetArea() {
            return quad.side1 * quad.side1;
        }

        public SquareComp(int sides) {
            quad = new Quad(sides, sides, sides, sides);
        }
    }
}
