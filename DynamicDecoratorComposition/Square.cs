using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDecoratorComposition
{
    public class Square : IShape
    {
        private float side;

        public Square(float side)
        {
            this.side = side;
        }

        public void Resize(float side)
        {
            this.side *= side;
        }

        public string AsString() => $"A circle with radius {side}";
    }
}
