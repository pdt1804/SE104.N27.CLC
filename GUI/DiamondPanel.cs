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
        // Methods
        private GraphicsPath GetDiamondPath(RectangleF rectangle, float borderRadius)
        {
            GraphicsPath path = new GraphicsPath();

            float radius = borderRadius / 2;
            PointF top = new PointF(rectangle.Left + rectangle.Width / 2, rectangle.Top);
            PointF right = new PointF(rectangle.Right, rectangle.Top + rectangle.Height / 2);
            PointF bottom = new PointF(rectangle.Left + rectangle.Width / 2, rectangle.Bottom);
            PointF left = new PointF(rectangle.Left, rectangle.Top + rectangle.Height / 2);

            path.AddArc(top.X - radius, top.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(right.X - borderRadius, right.Y - radius, borderRadius, borderRadius, 270, 90);
            path.AddArc(bottom.X - radius, bottom.Y - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(left.X, left.Y - radius, borderRadius, borderRadius, 90, 90);

            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Brush brush = new LinearGradientBrush(ClientRectangle, GradientTopColor, GradientBottomColor, GradientAngle))
            {
                GraphicsPath diamondPath = GetDiamondPath(ClientRectangle, BorderRadius);
                g.FillPath(brush, diamondPath);
            }
        }
    }
}
