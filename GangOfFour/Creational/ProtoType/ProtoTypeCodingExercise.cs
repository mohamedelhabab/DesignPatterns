using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.ProtoType
{
    public class ProtoTypeCodingExercise
    {
        public class Point
        {
            public int X, Y;

            public override string ToString()
            {
                return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
            }
        }

        public class Line
        {
            public Point Start, End;

            public Line DeepCopy()
            {
                return new Line()
                {
                    Start = new Point()
                    {
                        X = Start.X ,
                        Y =Start.Y
                    },
                    End = new Point()
                    {
                        X = End.X,
                        Y = End.Y
                    }
                };
            }

            public override string ToString()
            {
                return $"{nameof(Start)}: {Start}, {nameof(End)}: {End}";
            }
        }
    }
}
