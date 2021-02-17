using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAbstractionTutorial
{
    class Square
    {

        public Rectangle Rectangle { get; set; }

        public int Perimeter()
        {
            return Rectangle.Perimeter();
        }

        public int Area()
        {
            return Rectangle.Area();
        }

        public Square() { }

        public Square(int s1)
        {
            this.Rectangle = new Rectangle(s1, s1);
        }
    }
}
