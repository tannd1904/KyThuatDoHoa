﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa
{
    
    class Coor
    {
        private int x;
        private int y;
       
        public Coor()
        {
            X = 0;
            Y = 0;
            
        }

        public Coor(int x, int y)
        {
            this.X = x;
            this.Y = y;
            
        }

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }
       
    }
}
