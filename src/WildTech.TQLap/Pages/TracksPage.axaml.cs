using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WildTech.TQLap.Pages
{
    public class TracksPage : UserControl
    {
        public TracksPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
