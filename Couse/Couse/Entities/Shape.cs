using System;
using System.Collections.Generic;
using Couse.Entities;
using Couse.Entities.Enums;
using System.Text;

namespace Couse.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }


        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
