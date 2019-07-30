using System;
using System.Collections.Generic;
using System.Text;

namespace OopShapesProject {
    public class Rectangle : Quad {

        public int GetArea() { 
            return side1 * side2;
        }

        public Rectangle(int side_x, int side_y) : base(side_x, side_y, side_x, side_y) {

        
        }

       
        }
        
    }

