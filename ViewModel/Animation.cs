using System;
using System.Collections.Generic;
using NewInvaders.View;
using NewInvaders.Model;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;

namespace NewInvaders.ViewModel
{
    class Animation
    {
        private readonly ObservableCollection<UIElement>_sprites = new ObservableCollection<UIElement>();
        private Random _random = new Random();
        private Game game = new Game();
        private Rect boundaries;
        private List<Star> stars;



        public Animation()
        {
            boundaries = game.Boundaries;
            stars = game.CreateStars(boundaries);
        }

        private DispatcherTimer _timer = new DispatcherTimer();

        void timer_Tick(object sender, object e)
        {
            Twinkle(_random);
            
        }

        internal void Twinkle(Random random)
        {
            Star[] starsToRemove = new Star[5];
            UserControl[] starControl = { new SimpleStar(), new AnotherKindOfStar(), new TheLastKindOfStar() };
            for (int i = 0; i < 5; i++)
            {
                starsToRemove[i] = stars[random.Next(stars.Count)];
                stars.Remove(starsToRemove[i]);
                stars.Add(new Star(starsToRemove[i].Location, starControl[random.Next(starControl.Length)], random));
            }
        }
    }
}
