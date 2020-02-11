using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yLeft, int yRight, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                Point p1 = new Point(x, y, sym);
                pList.Add(p1);
            }

        }

        public void Drow()
        {
            foreach (Point p1 in pList)
            {
                p1.Draw();
            }
        }
    }
}
