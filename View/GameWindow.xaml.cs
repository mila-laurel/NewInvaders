using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NewInvaders.View
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        ViewModel.Animation viewModel;
        public GameWindow()
        {
            InitializeComponent();
            viewModel = FindResource("viewModel") as ViewModel.Animation;

        }
    }
}
