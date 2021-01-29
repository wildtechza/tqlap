//using ReactiveUI;
using System.Collections.Generic;

namespace WildTech.TQLap.Presentation.ViewModels
{
    public class MainWindowViewModel //: ReactiveObject, IMainWindowViewModel
    {
        public IEnumerable<MenuItemViewModel> MenuItems { get; } = new List<MenuItemViewModel>
        {
            // Global
            new MenuItemViewModel { Name = "Drivers", Description = "Test" },
            new MenuItemViewModel { Name = "Classes", Description = "Test" },

            // Event
            new MenuItemViewModel { Name = "Events", Description = "Test" },
            new MenuItemViewModel { Name = "Races", Description = "Test" }
        };

        public class MenuItemViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }

            //public override string ToString()
            //{
            //    return Name;
            //}
        }
    }
}