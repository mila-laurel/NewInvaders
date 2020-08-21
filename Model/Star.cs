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
        public Star(Point point, UIElement starControl, Random random)
        {
            Location = point;
            Pen = RandomPen(random);
            StarControl = starControl;
        }

        public Color RandomPen(Random random)
        {
            Color pen = Colors.Silver;
            switch (random.Next(4))
            {
                case 0:
                    pen = Colors.Silver;
                    break;
                case 1:
                    pen = Colors.Coral;
                    break;
                case 2:
                    pen = Colors.Gold;
                    break;
                default:
                    pen = Colors.Lavender;
                    break;
            }
            return pen;
        }
    }
}
