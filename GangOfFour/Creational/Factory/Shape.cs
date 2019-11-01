using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Factory
{
    public class Shape
    {
        private int linesCount;
        private double angleDegree;
        public string shapeType { get; set; }

        private Shape(int linesCount, double angleDegree,string shapeType)
        {
            this.linesCount = linesCount;
            this.angleDegree = angleDegree;
            this.shapeType = shapeType;
        }

      public static class Factory
      {
          public static Shape MakeTriangle(double angleDegree)
          {
              return new Shape(3 , angleDegree , "Triangle");
          }
          public static Shape MakeSquare()
          {
              return new Shape(4, 90,"Square");
          }
          public static Shape MakePolygon(int linesCount, double angleDegree)
          {
              return new Shape(linesCount, angleDegree, "Polygon");
          }

        }

    }
}
