using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake
    {
        public Snake() 
        {
            this.Head = new Point(1, 1) ;
            this.Body = new List<Point>();
        }

        public Point Head { set; get; }
        public List<Point> Body { set; get; }
    }
}
