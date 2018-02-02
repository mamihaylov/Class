using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine("[topleft: {0},{1},{2}, bottomRight: {3},{4},{5}",
                topLeft.X, topLeft.X, TopLeft.Color, bottomRight.X, bottomRight.Y, bottomRight.Color);
        }
        //
        Rectangle myRect = new Rectangle
        {
            TopLeft = new Point { X = 10, Y = 10 },
            BottomRight = new Point { X = 10, Y = 10 }

        };
    }
}
