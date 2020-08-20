using System;
using System.Collections.Generic;
using NewInvaders.View;
using NewInvaders.Model;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Threading;

namespace NewInvaders.ViewModel
{
    class Animation
    {
        private readonly ObservableCollection<UIElement>_sprites = new ObservableCollection<UIElement>();
        private readonly Dictionary<Star, SimpleStar> _simleStars = new Dictionary<Star, SimpleStar>();
        private readonly Dictionary<Star, AnotherKindOfStar> _otherStars = new Dictionary<Star, AnotherKindOfStar>();
        private readonly Dictionary<Star, TheLastKindOfStar> _lastStars = new Dictionary<Star, TheLastKindOfStar>();
        private DispatcherTimer _timer = new DispatcherTimer();

        void timer_Tick(object sender, object e)
        {
            
        }
    }
}
