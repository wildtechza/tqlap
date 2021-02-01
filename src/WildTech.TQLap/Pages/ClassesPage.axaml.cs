using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WildTech.TQLap.Pages
{
    public class ClassesPage : UserControl
    {
        public ClassesPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
