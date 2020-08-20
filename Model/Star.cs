using System;
using System.Windows;
using System.Windows.Media;

namespace NewInvaders.Model
{
    class Star
    {
        public Point Location { get; private set; }
        public Color Pen { get; set; }
        public UIElement StarControl { get; set; }
        public Star(Point point, Color pen, UIElement starControl)
        {
            Location = point;
            Pen = pen;
            StarControl = starControl;
        }
    }
}
