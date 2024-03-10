using System;

using EmuXS2.ViewModels;

using Windows.UI.Xaml.Controls;

namespace EmuXS2.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
