﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_l
{
    public class OBlock
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[]
            {  new Position(0, 0), new Position(0, 1), new Position(1, 0), new Position(1, 1)}
        };

        public override int Id => 4;
        protected override Position StartOffset => new Position(0, 4);
        protected override Position[][] Tiles => Tiles;
    }
}
