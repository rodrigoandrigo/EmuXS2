using Windows.UI.Xaml.Controls;
using Microsoft.Graphics.Canvas.UI.Xaml;
using Windows.UI;
using Microsoft.Graphics.Canvas;

namespace EmuXS2.Views
{
    public sealed partial class ScreenPage : Page
    {

        public ScreenPage()
        {
            InitializeComponent();
        }
        private void CanvasControl_Draw_1(CanvasControl sender, CanvasDrawEventArgs args)
        {
            args.DrawingSession.DrawEllipse(155, 115, 80, 30, Colors.Black, 3);
            args.DrawingSession.DrawText("Hello, world!", 100, 100, Colors.Yellow);
            args.DrawingSession.Antialiasing = CanvasAntialiasing.Antialiased;
        }
    }
}
