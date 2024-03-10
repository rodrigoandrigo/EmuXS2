using System;
using System.IO;
using EmuXS2.ConPTY;
using EmuXS2.ConPTY.Interop.Definitions;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;

namespace EmuXS2.Views
{
    public sealed partial class TermiPage : Page
    {
        public TermConPTY termConPTY;

        public TermiPage()
        {
            InitializeComponent();

            termConPTY = new TermConPTY
            {
                WorkingDirectory = Directory.GetCurrentDirectory(),
                Arguments = string.Empty,
                FilterControlSequences = true,
            };

            termConPTY.OutputDataReceived += async (sender, data) =>
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    Run Data1;
                    Data1 = new Run();
                    Data1.Text = data + "\n";
                    Paragrafo.Inlines.Add(Data1);
                });
            };


            ProcessInfo processInfo = termConPTY.Start();
        }
        public void TextBox1_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                termConPTY.WriteLine(TextBox1.Text + "\n");
                e.Handled = true;
                TextBox1.Text = "";
            }

        }
    }
}
