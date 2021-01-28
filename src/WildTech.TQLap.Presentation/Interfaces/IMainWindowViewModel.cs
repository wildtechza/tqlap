using System.Collections.Generic;
using System.ComponentModel;
using WildTech.TQLap.Presentation.ViewModels;

namespace WildTech.TQLap.Presentation.Interfaces
{
    public interface IMainWindowViewModel : INotifyPropertyChanged
    {
        IEnumerable<MainWindowViewModel.MenuItemViewModel> MenuItems { get; }
    }
}