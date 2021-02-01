using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WildTech.TQLap.Controls
{
    public class TrackControl : UserControl
    {
        public TrackControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
