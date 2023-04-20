﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Point
    {
        public Point()
        {
        }

        public Point(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }

        public int Row { get; set; }

        public int Column { get; set; }
    }
}
