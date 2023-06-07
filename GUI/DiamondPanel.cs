using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace GUI
{
    public class DiamondPanel : Panel
    {
        // Properties
        public Color GradientTopColor { get; set; }
        public Color GradientBottomColor { get; set; }
        public int GradientAngle { get; set; }
        public float BorderRadius { get; set; }

        // Constructor
        public DiamondPanel()
        {
            GradientTopColor = Color.White;
            GradientBottomColor = Color.Gray;
            GradientAngle = 45;
            BorderRadius = 10;
        }

    }  
}
