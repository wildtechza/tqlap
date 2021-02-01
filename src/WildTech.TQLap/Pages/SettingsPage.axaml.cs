using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WildTech.TQLap.Pages
{
    public class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
