﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autoritaereFactory.setup;

namespace autoritaereFactory.world
{
    internal class Chunk
    {
        public const int chunkSize = 32;
        public int x, y;
        public List<Building> buildings;
        BlockState[,] blockState;
        public Chunk()
        {
            blockState = new BlockState[chunkSize,chunkSize]; 
        }
        public BlockState GetSubChunk(int innerX, int innerY)
        {
            return blockState[innerX,innerY];
        }
    }
}
