using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WildTech.TQLap.Pages
{
    public class WelcomePage : UserControl
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
