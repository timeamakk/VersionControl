using _08het.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08het.Entities
{
    public class Present : Toy
    {
        public SolidBrush PresentColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }
        public Present(Color color, Color ribboncolor)
        {
            PresentColor = new SolidBrush(color);
            RibbonColor = new SolidBrush(ribboncolor);
        }


        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(PresentColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor , (Width/11)*5, 0 ,  Width/6, Height);
            g.FillRectangle(RibbonColor,  0, (Width / 11) * 5, Width, Height / 6);
        }
    }
}
