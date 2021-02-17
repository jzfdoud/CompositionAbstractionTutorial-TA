using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAbstractionTutorial
{
    class Rectangle
    {

        public Quad Quad { get; set; }

        public int Area()
        {
            return Convert.ToInt32(Quad.Side1 * Quad.Side2);
                
        }


        public int Perimeter()
        {
            var p = Quad.Perimeter();
            var pi = Convert.ToInt32(p);
            return pi;
        }

        public double PerimeterAsDouble()
        {
            return Quad.Perimeter();
        }

        public Rectangle() { }

        public Rectangle(int s1, int s2)
        {
            this.Quad = new Quad(s1, s2, s1, s2);
        }
    }
}
