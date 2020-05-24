using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution
{
    public class Square : Rectangle
    {
        public override int Width // nasty side effects
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Height = base.Width = value; }
        }
    }
}
