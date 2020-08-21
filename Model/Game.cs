using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using NewInvaders.View;
using NewInvaders.ViewModel;

namespace NewInvaders.Model
{
    class Game
    {
        private GameWindow window = new GameWindow();
        private Rect boundaries;
        public Rect Boundaries { get { return boundaries; } set { boundaries = new Rect(0, 0, window.ActualWidth, window.ActualHeight); } }

        public List<Star> CreateStars(Rect boundaries)
        {
            Random random = new Random();
            List<Star> stars = new List<Star>();
            for (int i = 0; i < 100; i++)
            {
                stars.Add(new Star(new Point(random.Next((int)boundaries.Width), random.Next((int)boundaries.Height)), new SimpleStar(), random));
            }
            for (int i = 100; i < 200; i++)
            {
                stars.Add(new Star(new Point(random.Next((int)boundaries.Width), random.Next((int)boundaries.Height)), new AnotherKindOfStar(), random));
            }
            for (int i = 200; i < 300; i++)
            {
                stars.Add(new Star(new Point(random.Next((int)boundaries.Width), random.Next((int)boundaries.Height)), new TheLastKindOfStar(), random));
            }
            return stars;
        }
    }
}
