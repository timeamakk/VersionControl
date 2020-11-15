﻿using _08het.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08het.Abstractions
{
    public class PresentFactory : IToyFactory
    {
        public Color PresentColor { get; set; }
        public Color RibbonColor { get; set; }

        

        public Toy CreateNew()
        {
            return new Present(PresentColor, RibbonColor);
        }

    }
}
