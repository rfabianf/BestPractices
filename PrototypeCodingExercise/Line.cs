using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeCodingExercise
{
    public class Line
    {
        public Point Start, End;
        public Line DeepCopy()
        {
            return new Line()
            {
                Start = new Point() { X = Start.X, Y = Start.Y},
                End = new Point() { X = End.X, Y = End.Y }
            };
        }

        public override string ToString()
        {
            return $"{nameof(Line)}:{nameof(Start)}:{Start.X},{Start.Y}{nameof(End)}:{End.X},{End.Y}";
        }
    }
}
